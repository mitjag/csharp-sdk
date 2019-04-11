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

            byte[] signature = assembler.Sign(transferMessage);
            Assert.Equal("8ad9bc7fd3ebf41a1a8874d643873affdc3ef77cb40cfba72795815574b4cc720dcef0da455afbcd97b9cf70d88ecb1f060610f0b48eda2752b213f6fa553bd6", EncodeUtils.ByteArrayToString(signature), true);

            byte[] encodedSignature = assembler.EncodeSignature(signature);
            Assert.Equal("0a26eb5ae987210216087947712ad02e55bf34a227974644f5a6cca391771b3868b495d62c5f7b1a12408ad9bc7fd3ebf41a1a8874d643873affdc3ef77cb40cfba72795815574b4cc720dcef0da455afbcd97b9cf70d88ecb1f060610f0b48eda2752b213f6fa553bd6200b", EncodeUtils.ByteArrayToString(encodedSignature), true);

            byte[] encodeStdTx = assembler.EncodeStdTx(encodeMessage, encodedSignature);
            Assert.Equal("c001f0625dee0a4c2a2c87fa0a220a1454d41d0b0c4603cd932605e61880abc2a2af7e25120a0a03424e421080c2d72f12220a14183b441b6814af90b2d76ad96e19b52008c53bd0120a0a03424e421080c2d72f126c0a26eb5ae987210216087947712ad02e55bf34a227974644f5a6cca391771b3868b495d62c5f7b1a12408ad9bc7fd3ebf41a1a8874d643873affdc3ef77cb40cfba72795815574b4cc720dcef0da455afbcd97b9cf70d88ecb1f060610f0b48eda2752b213f6fa553bd6200b", EncodeUtils.ByteArrayToString(encodeStdTx), true);

            //assembler.BuildTransfer(transfer);
        }
    }
}
