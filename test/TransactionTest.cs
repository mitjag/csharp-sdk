using binance.dex.sdk.broadcast;
using binance.dex.sdk.crypto;
using binance.dex.sdk.message;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace binance.dex.sdk.test
{
    public class TransactionTest
    {
        [Fact]
        public void TransferTest()
        {
            //List<string> words = new List<string> { "slot live best metal mandate page hover tank bronze code salad hill hen salad train inmate autumn nut home city shield level board measure" };
            Wallet wallet = new Wallet("db923c5e1b5b2db221da5d14bdc41c5fb3c15510bf1fb2bc8faf33679dd85e54", BinanceDexEnvironment.TEST_NET);
            Assert.Equal("tbnb12n2p6zcvgcpumyexqhnp3q9tc2327l39ycfnyk", wallet.Address);
            wallet.AccountNumber = 0;
            wallet.Sequence = 11L;
            wallet.ChainId = "test-chain-n4b735";

            TransactionOption options = new TransactionOption { Memo = "", Source = 0, Data = null };
            TransactionRequest assembler = new TransactionRequest(wallet, options);

            Transfer transfer = new Transfer
            {
                Coin = "BNB",
                FromAddress = wallet.Address,
                ToAddress = "tbnb1rqa5gxmgzjhepvkhdtvkuxd4yqyv2w7sm8p78g",
                Amount = "1"
            };

            TransferMessage transferMessage = assembler.CreateTransferMessage(transfer);
            byte[] encodeMessage = assembler.EncodeTransferMessage(transferMessage);
            string encodedMessageString = EncodeUtils.ByteArrayToString(encodeMessage);
            Assert.Equal("2a2c87fa0a220a1454d41d0b0c4603cd932605e61880abc2a2af7e25120a0a03424e421080c2d72f12220a14183b441b6814af90b2d76ad96e19b52008c53bd0120a0a03424e421080c2d72f", encodedMessageString, true);
            //assembler.BuildTransfer(transfer);

        }
    }
}
