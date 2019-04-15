using binance.dex.sdk.broadcast;
using binance.dex.sdk.crypto;
using binance.dex.sdk.proto;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace binance.dex.sdk.message
{
    public class TransactionRequest
    {
        private const decimal MULTIPLY_FACTOR = 1e8M;

        public Wallet Wallet { get; }

        public TransactionOption TranscationOption { get; }

        public TransactionRequest(Wallet wallet, TransactionOption transcationOption)
        {
            Wallet = wallet;
            TranscationOption = transcationOption;
        }

        private static long DoubleToLong(String d)
        {
            decimal encodeValue = decimal.Multiply(decimal.Parse(d, NumberStyles.Currency, CultureInfo.InvariantCulture), MULTIPLY_FACTOR);
            if (encodeValue.CompareTo(decimal.Zero) <= 0)
            {
                throw new ArgumentException(d + " is less or equal to zero.");
            }
            if (encodeValue.CompareTo(long.MaxValue) > 0)
            {
                throw new ArgumentException(d + " is too large.");
            }
            return decimal.ToInt64(encodeValue);
        }

        private byte[] Sign(ITransactionMessage msg)
        {
            SignData signData = new SignData();
            signData.ChainId = Wallet.ChainId;
            signData.AccountNumber = Wallet.AccountNumber.ToString();
            signData.Sequence = Wallet.Sequence.ToString();
            signData.Msgs = new ITransactionMessage[] { msg };
            signData.Memo = TranscationOption.Memo;
            signData.Source = TranscationOption.Source.ToString();
            signData.Data = TranscationOption.Data;
            return Signature.Sign(signData, Wallet.EcKey);
        }

        private TransferMessage CreateTransferMessage(Transfer transfer)
        {
            Token token = new Token();
            token.Denom = transfer.Coin;
            token.Amount = DoubleToLong(transfer.Amount);
            List<Token> coins = new List<Token> { token };

            InputOutput input = new InputOutput();
            input.Address = transfer.FromAddress;
            input.Coins = coins;
            InputOutput output = new InputOutput();
            output.Address = transfer.ToAddress;
            output.Coins = coins;

            TransferMessage msgBean = new TransferMessage();
            msgBean.Inputs = new List<InputOutput> { input };
            msgBean.Outputs = new List<InputOutput> { output };
            return msgBean;
        }

        private Send.Types.Input toProtoInput(InputOutput inputOutput)
        {
            Send.Types.Input input = new Send.Types.Input();
            byte[] address = Wallet.DecodeAddress(inputOutput.Address);
            input.Address = ByteString.CopyFrom(address);
            foreach (Token coin in inputOutput.Coins)
            {
                Send.Types.Token protCoin = new Send.Types.Token
                {
                    Amount = coin.Amount,
                    Denom = coin.Denom
                };
                input.Coins.Add(protCoin);
            }
            return input;
        }

        private Send.Types.Output toProtoOutput(InputOutput inputOutput)
        {
            Send.Types.Output output = new Send.Types.Output();
            byte[] address = Wallet.DecodeAddress(inputOutput.Address);
            output.Address = ByteString.CopyFrom(address);
            foreach (Token coin in inputOutput.Coins)
            {
                Send.Types.Token protCoin = new Send.Types.Token
                {
                    Amount = coin.Amount,
                    Denom = coin.Denom
                };
                output.Coins.Add(protCoin);
            }
            return output;
        }

        private byte[] EncodeTransferMessage(TransferMessage transferMessage)
        {
            Send send = new Send();
            foreach (InputOutput input in transferMessage.Inputs)
            {
                send.Inputs.Add(toProtoInput(input));
            }
            foreach (InputOutput output in transferMessage.Outputs)
            {
                send.Outputs.Add(toProtoOutput(output));
            }
            ;
            return EncodeUtils.AminoWrap(send.ToByteArray(), MessageType.GetTransactionType(EMessageType.Send), false);
        }

        private byte[] EncodeSignature(byte[] signatureBytes)
        {
            StdSignature stdSignature = new StdSignature
            {
                PubKey = ByteString.CopyFrom(Wallet.PubKeyForSign),
                Signature = ByteString.CopyFrom(signatureBytes),
                AccountNumber = Wallet.AccountNumber.Value,
                Sequence = Wallet.Sequence.Value
            };

            return EncodeUtils.AminoWrap(stdSignature.ToByteArray(), MessageType.GetTransactionType(EMessageType.StdSignature), false);
        }

        private byte[] EncodeStdTx(byte[] msg, byte[] signature)
        {
            StdTx stdTx = new StdTx();
            stdTx.Msgs.Add(ByteString.CopyFrom(msg));
            stdTx.Signatures.Add(ByteString.CopyFrom(signature));
            stdTx.Memo = TranscationOption.Memo;
            stdTx.Source = TranscationOption.Source;
            if (TranscationOption.Data != null)
            {
                stdTx.Data = ByteString.CopyFrom(TranscationOption.Data);
            }
            return EncodeUtils.AminoWrap(stdTx.ToByteArray(), MessageType.GetTransactionType(EMessageType.StdTx), true);
        }

        public string BuildTransfer(Transfer transfer)
        {
            Wallet.EnsureWalletIsReady();
            TransferMessage msgBean = CreateTransferMessage(transfer);
            byte[] msg = EncodeTransferMessage(msgBean);
            byte[] signature = EncodeSignature(Sign(msgBean));
            byte[] stdTx = EncodeStdTx(msg, signature);
            return EncodeUtils.ByteArrayToString(stdTx);
        }
    }
}
