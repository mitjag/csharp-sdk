using binance.dex.sdk.broadcast;
using binance.dex.sdk.crypto;
using binance.dex.sdk;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using binance.dex.sdk.model;

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

        private byte[] EncodeSignature(byte[] signatureBytes)
        {
            proto.StdSignature stdSignature = new proto.StdSignature
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
            proto.StdTx stdTx = new proto.StdTx();
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

        private String GenerateOrderId()
        {
            return EncodeUtils.ByteArrayToHex(Wallet.AddressBytes).ToUpper() + "-" + (Wallet.Sequence + 1);
        }

        #region Build Transaction Messages
        public string BuildNewOrder(NewOrder newOrder)
        {
            Wallet.EnsureWalletIsReady();
            NewOrderMessage msgBean = CreateNewOrderMessage(newOrder);
            byte[] msg = EncodeNewOrderMessage(msgBean);
            byte[] signature = EncodeSignature(Sign(msgBean));
            byte[] stdTx = EncodeStdTx(msg, signature);
            return EncodeUtils.ByteArrayToHex(stdTx);
        }

        public string BuildVote(Vote vote)
        {
            Wallet.EnsureWalletIsReady();
            VoteMessage msgBean = CreateVoteMessage(vote);
            byte[] msg = EncodeVoteMessage(msgBean);
            byte[] signature = EncodeSignature(Sign(msgBean));
            byte[] stdTx = EncodeStdTx(msg, signature);
            return EncodeUtils.ByteArrayToHex(stdTx);
        }

        public string BuildCancelOrder(CancelOrder cancelOrder)
        {
            Wallet.EnsureWalletIsReady();
            CancelOrderMessage msgBean = CreateCancelOrderMessage(cancelOrder);
            byte[] msg = EncodeCancelOrderMessage(msgBean);
            byte[] signature = EncodeSignature(Sign(msgBean));
            byte[] stdTx = EncodeStdTx(msg, signature);
            return EncodeUtils.ByteArrayToHex(stdTx);
        }

        public string BuildTransfer(Transfer transfer)
        {
            Wallet.EnsureWalletIsReady();
            TransferMessage msgBean = CreateTransferMessage(transfer);
            byte[] msg = EncodeTransferMessage(msgBean);
            byte[] signature = EncodeSignature(Sign(msgBean));
            byte[] stdTx = EncodeStdTx(msg, signature);
            return EncodeUtils.ByteArrayToHex(stdTx);
        }

        public string BuildTokenFreeze(TokenFreeze tokenFreeze)
        {
            Wallet.EnsureWalletIsReady();
            TokenFreezeMessage msgBean = CreateTokenFreezeMessage(tokenFreeze);
            byte[] msg = EncodeTokenFreezeMessage(msgBean);
            byte[] signature = EncodeSignature(Sign(msgBean));
            byte[] stdTx = EncodeStdTx(msg, signature);
            return EncodeUtils.ByteArrayToHex(stdTx);
        }

        public string BuildTokenUnfreeze(TokenUnfreeze tokenUnfreeze)
        {
            Wallet.EnsureWalletIsReady();
            TokenUnfreezeMessage msgBean = CreateTokenUnfreezeMessage(tokenUnfreeze);
            byte[] msg = EncodeTokenUnfreezeMessage(msgBean);
            byte[] signature = EncodeSignature(Sign(msgBean));
            byte[] stdTx = EncodeStdTx(msg, signature);
            return EncodeUtils.ByteArrayToHex(stdTx);
        }

        public string BuildMultiTransfer(MultiTransfer multiTransfer)
        {
            Wallet.EnsureWalletIsReady();
            TransferMessage msgBean = CreateMultiTransferMessage(multiTransfer);
            byte[] msg = EncodeTransferMessage(msgBean);
            byte[] signature = EncodeSignature(Sign(msgBean));
            byte[] stdTx = EncodeStdTx(msg, signature);
            return EncodeUtils.ByteArrayToHex(stdTx);
        }
        #endregion

        #region NewOrderMessage
        private NewOrderMessage CreateNewOrderMessage(NewOrder newOrder)
        {
            return new NewOrderMessage
            {
                Id = GenerateOrderId(),
                OrderType = OrderType.ToOrderType(newOrder.OrderType),
                Price = DoubleToLong(newOrder.Price),
                Quantity = DoubleToLong(newOrder.Quantity),
                Sender = Wallet.Address,
                Side = OrderSide.ToOrderSide(newOrder.Side),
                Symbol = newOrder.Symbol,
                TimeInForce = TimeInForce.ToTimeInForce(newOrder.TimeInForce),
            };
        }

        private byte[] EncodeNewOrderMessage(NewOrderMessage newOrderMessage)
        {
            proto.NewOrder newOrder = new proto.NewOrder
            {
                Sender = ByteString.CopyFrom(Wallet.AddressBytes),
                Id = newOrderMessage.Id,
                Symbol = newOrderMessage.Symbol,
                Ordertype = newOrderMessage.OrderType,
                Side = newOrderMessage.Side,
                Price = newOrderMessage.Price,
                Quantity = newOrderMessage.Quantity,
                Timeinforce = newOrderMessage.TimeInForce
            };
            return EncodeUtils.AminoWrap(newOrder.ToByteArray(), MessageType.GetTransactionType(EMessageType.NewOrder), false);
        }
        #endregion

        #region VoteMessage
        private VoteMessage CreateVoteMessage(Vote vote)
        {
            return new VoteMessage
            {
                ProposalId = vote.ProposalId.ToString(),
                Option = VoteMessage.ToOption(vote.Option),
                Voter = Wallet.Address
            };
        }

        private byte[] EncodeVoteMessage(VoteMessage voteMessage)
        {
            proto.Vote vote = new proto.Vote
            {
                Voter = ByteString.CopyFrom(Wallet.AddressBytes),
                ProposalId = long.Parse(voteMessage.ProposalId),
                Option = VoteMessage.ToOption(voteMessage.Option)
            };
            return EncodeUtils.AminoWrap(vote.ToByteArray(), MessageType.GetTransactionType(EMessageType.Vote), false);
        }
        #endregion

        #region CancelOrderMessage
        private CancelOrderMessage CreateCancelOrderMessage(CancelOrder cancelOrder)
        {
            return new CancelOrderMessage
            {
                RefId = cancelOrder.RefId,
                Symbol = cancelOrder.Symbol,
                Sender = Wallet.Address
            };
        }

        private byte[] EncodeCancelOrderMessage(CancelOrderMessage cancelOrderMessage)
        {
            proto.CancelOrder cancelOrder = new proto.CancelOrder
            {
                Sender = ByteString.CopyFrom(Wallet.AddressBytes),
                Symbol = cancelOrderMessage.Symbol,
                Refid = cancelOrderMessage.RefId
            };
            return EncodeUtils.AminoWrap(cancelOrder.ToByteArray(), MessageType.GetTransactionType(EMessageType.CancelOrder), false);
        }
        #endregion

        #region TransferMessage
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

        private proto.Send.Types.Input toProtoInput(InputOutput inputOutput)
        {
            proto.Send.Types.Input input = new proto.Send.Types.Input();
            byte[] address = Wallet.DecodeAddress(inputOutput.Address);
            input.Address = ByteString.CopyFrom(address);
            foreach (Token coin in inputOutput.Coins)
            {
                proto.Send.Types.Token protCoin = new proto.Send.Types.Token
                {
                    Amount = coin.Amount,
                    Denom = coin.Denom
                };
                input.Coins.Add(protCoin);
            }
            return input;
        }

        private proto.Send.Types.Output toProtoOutput(InputOutput inputOutput)
        {
            proto.Send.Types.Output output = new proto.Send.Types.Output();
            byte[] address = Wallet.DecodeAddress(inputOutput.Address);
            output.Address = ByteString.CopyFrom(address);
            foreach (Token coin in inputOutput.Coins)
            {
                proto.Send.Types.Token protCoin = new proto.Send.Types.Token
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
            proto.Send send = new proto.Send();
            foreach (InputOutput input in transferMessage.Inputs)
            {
                send.Inputs.Add(toProtoInput(input));
            }
            foreach (InputOutput output in transferMessage.Outputs)
            {
                send.Outputs.Add(toProtoOutput(output));
            }
            return EncodeUtils.AminoWrap(send.ToByteArray(), MessageType.GetTransactionType(EMessageType.Send), false);
        }
        #endregion

        #region TokenFreezeMessage
        private TokenFreezeMessage CreateTokenFreezeMessage(TokenFreeze tokenFreeze)
        {
            return new TokenFreezeMessage
            {
                Amount = DoubleToLong(tokenFreeze.Amount),
                From = Wallet.Address,
                Symbol = tokenFreeze.Symbol
            };
        }

        private byte[] EncodeTokenFreezeMessage(TokenFreezeMessage tokenFreezeMessage)
        {
            proto.TokenFreeze tokenFreeze = new proto.TokenFreeze
            {
                From = ByteString.CopyFrom(Wallet.DecodeAddress(tokenFreezeMessage.From)),
                Amount = tokenFreezeMessage.Amount,
                Symbol = tokenFreezeMessage.Symbol
            };
            return EncodeUtils.AminoWrap(tokenFreeze.ToByteArray(), MessageType.GetTransactionType(EMessageType.TokenFreeze), false);
        }
        #endregion

        #region TokenUnfreezeMessage
        private TokenUnfreezeMessage CreateTokenUnfreezeMessage(TokenUnfreeze tokenUnfreeze)
        {
            return new TokenUnfreezeMessage
            {
                Amount = DoubleToLong(tokenUnfreeze.Amount),
                From = Wallet.Address,
                Symbol = tokenUnfreeze.Symbol
            };
        }

        private byte[] EncodeTokenUnfreezeMessage(TokenUnfreezeMessage tokenUnfreezeMessage)
        {
            proto.TokenUnfreeze tokenUnfreeze = new proto.TokenUnfreeze
            {
                From = ByteString.CopyFrom(Wallet.DecodeAddress(tokenUnfreezeMessage.From)),
                Amount = tokenUnfreezeMessage.Amount,
                Symbol = tokenUnfreezeMessage.Symbol
            };
            return EncodeUtils.AminoWrap(tokenUnfreeze.ToByteArray(), MessageType.GetTransactionType(EMessageType.TokenUnfreeze), false);
        }
        #endregion

        #region MultiTransferMessage
        private TransferMessage CreateMultiTransferMessage(MultiTransfer multiTransfer)
        {
            Dictionary<string, long> inputsCoins = new Dictionary<string, long>();
            List<InputOutput> outputs = new List<InputOutput>();
            foreach (Output output in multiTransfer.Outputs)
            {
                InputOutput inputOutput = new InputOutput
                {
                    Address = output.Address
                };
                List<Token> tokens = new List<Token>(output.Tokens.Count);
                foreach (OutputToken outputToken in output.Tokens)
                {
                    Token token = new Token
                    {
                        Denom = outputToken.Coin,
                        Amount = DoubleToLong(outputToken.Amount)
                    };
                    tokens.Add(token);

                    long inputSum = inputsCoins.GetValueOrDefault(outputToken.Coin, 0L);
                    long newSum = inputSum + token.Amount;
                    if (newSum < 0L)
                    {
                        throw new ArgumentException("Transfer amount overflow");
                    }
                    inputsCoins.Add(outputToken.Coin, newSum);
                }
                tokens.Sort((x, y) => (x.Denom.CompareTo(y.Denom)));
                inputOutput.Coins = tokens;
                outputs.Add(inputOutput);
            }

            InputOutput input = new InputOutput()
            {
                Address = multiTransfer.FromAddress
            };
            List<Token> inputTokens = new List<Token>(inputsCoins.Count);
            foreach (string coin in inputsCoins.Keys)
            {
                Token token = new Token()
                {
                    Denom = coin,
                    Amount = inputsCoins[coin]
                };
                inputTokens.Add(token);
            }
            input.Coins = inputTokens;

            TransferMessage transferMessage = new TransferMessage();
            transferMessage.Inputs = new List<InputOutput> { input };
            transferMessage.Outputs = outputs;
            return transferMessage;
        }
        #endregion
    }
}
