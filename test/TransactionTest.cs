using binance.dex.sdk.broadcast;
using binance.dex.sdk.crypto;
using binance.dex.sdk.message;
using binance.dex.sdk.model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace binance.dex.sdk.test
{
    public class TransactionTest
    {
        [Fact]
        public void WalletTest()
        {
            Wallet wallet = new Wallet("95949f757db1f57ca94a5dff23314accbe7abee89597bf6a3c7382c84d7eb832",
                BinanceDexEnvironment.TEST_NET);
            Assert.Equal("tbnb1grpf0955h0ykzq3ar5nmum7y6gdfl6lx8xu7hm", wallet.Address);
            Assert.Equal("40c2979694bbc961023d1d27be6fc4d21a9febe6",
                EncodeUtils.ByteArrayToHex(wallet.AddressBytes), true);
            Assert.Equal("eb5ae98721026a35920088d98c3888ca68c53dfc93f4564602606cbb87f0fe5ee533db38e502",
                EncodeUtils.ByteArrayToHex(wallet.PubKeyForSign), true);
        }

        [Fact]
        public void TransferTest()
        {
            //List<string> words = new List<string> { "slot live best metal mandate page hover tank bronze code salad hill hen salad train inmate autumn nut home city shield level board measure" };
            //Wallet wallet = Wallet.createWalletFromMnemonicCode(words, BinanceDexEnvironment.TEST_NET);
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

            /*TransferMessage transferMessage = assembler.CreateTransferMessage(transfer);
            byte[] encodeMessage = assembler.EncodeTransferMessage(transferMessage);
            string encodedMessageString = EncodeUtils.ByteArrayToString(encodeMessage);
            Assert.Equal("2a2c87fa0a220a1454d41d0b0c4603cd932605e61880abc2a2af7e25120a0a03424e421080c2d72f12220a14183b441b6814af90b2d76ad96e19b52008c53bd0120a0a03424e421080c2d72f", encodedMessageString, true);

            byte[] signature = assembler.Sign(transferMessage);
            Assert.Equal("8ad9bc7fd3ebf41a1a8874d643873affdc3ef77cb40cfba72795815574b4cc720dcef0da455afbcd97b9cf70d88ecb1f060610f0b48eda2752b213f6fa553bd6", EncodeUtils.ByteArrayToString(signature), true);

            byte[] encodedSignature = assembler.EncodeSignature(signature);
            Assert.Equal("0a26eb5ae987210216087947712ad02e55bf34a227974644f5a6cca391771b3868b495d62c5f7b1a12408ad9bc7fd3ebf41a1a8874d643873affdc3ef77cb40cfba72795815574b4cc720dcef0da455afbcd97b9cf70d88ecb1f060610f0b48eda2752b213f6fa553bd6200b", EncodeUtils.ByteArrayToString(encodedSignature), true);

            byte[] encodeStdTx = assembler.EncodeStdTx(encodeMessage, encodedSignature);
            Assert.Equal("c001f0625dee0a4c2a2c87fa0a220a1454d41d0b0c4603cd932605e61880abc2a2af7e25120a0a03424e421080c2d72f12220a14183b441b6814af90b2d76ad96e19b52008c53bd0120a0a03424e421080c2d72f126c0a26eb5ae987210216087947712ad02e55bf34a227974644f5a6cca391771b3868b495d62c5f7b1a12408ad9bc7fd3ebf41a1a8874d643873affdc3ef77cb40cfba72795815574b4cc720dcef0da455afbcd97b9cf70d88ecb1f060610f0b48eda2752b213f6fa553bd6200b", EncodeUtils.ByteArrayToString(encodeStdTx), true);*/

            string build = assembler.BuildTransfer(transfer);
            Assert.Equal("c001f0625dee0a4c2a2c87fa0a220a1454d41d0b0c4603cd932605e61880abc2a2af7e25120a0a03424e421080c2d72f12220a14183b441b6814af90b2d76ad96e19b52008c53bd0120a0a03424e421080c2d72f126c0a26eb5ae987210216087947712ad02e55bf34a227974644f5a6cca391771b3868b495d62c5f7b1a12408ad9bc7fd3ebf41a1a8874d643873affdc3ef77cb40cfba72795815574b4cc720dcef0da455afbcd97b9cf70d88ecb1f060610f0b48eda2752b213f6fa553bd6200b", build, true);
        }

        [Fact]
        public void NewOrderTest()
        {
            //List<String> words = Arrays.asList("slot live best metal mandate page hover tank bronze code salad hill hen salad train inmate autumn nut home city shield level board measure".split(" "));
            //Wallet wallet = Wallet.createWalletFromMnemonicCode(words, BinanceDexEnvironment.TEST_NET);
            Wallet wallet = new Wallet("db923c5e1b5b2db221da5d14bdc41c5fb3c15510bf1fb2bc8faf33679dd85e54", BinanceDexEnvironment.TEST_NET);
            Assert.Equal("tbnb12n2p6zcvgcpumyexqhnp3q9tc2327l39ycfnyk", wallet.Address);

            wallet.AccountNumber = 0;
            wallet.Sequence = 14L;
            wallet.ChainId = "test-chain-n4b735";

            TransactionOption options = new TransactionOption { Memo = "", Source = 0, Data = null };
            TransactionRequest assembler = new TransactionRequest(wallet, options);

            NewOrder newOrder = new NewOrder
            {
                Symbol = "NNB-274_BNB",
                Side = EOrderSide.Sell,
                OrderType = EOrderType.Limit,
                Price = "2",
                Quantity = "15",
                TimeInForce = ETimeInForce.GTE
            };

            //NewOrderMessage msgBean = assembler.createNewOrderMessage(no);
            //byte[] encodedMsg = assembler.encodeNewOrderMessage(msgBean);
            //Assert.assertEquals("ce6dc0430a1454d41d0b0c4603cd932605e61880abc2a2af7e25122b353444343144304230433436303343443933323630354536313838304142433241324146374532352d31351a0b4e4e422d3237345f424e4220022802308084af5f3880dea0cb054001", EncodeUtils.bytesToHex(encodedMsg));
            //byte[] signature = assembler.sign(msgBean);
            //Assert.assertEquals("44B2B9293EC4867FC2C77C822E13F090E8C6502ECBBC3349AF794E45C6FC8A9823728BCC3B482BF82B4A954F8A7BC1981E1BE4877B62311084C50FD95CAE06AE".toLowerCase(), EncodeUtils.bytesToHex(signature));
            //byte[] encodedSignature = assembler.encodeSignature(signature);
            //Assert.assertEquals("0a26eb5ae987210216087947712ad02e55bf34a227974644f5a6cca391771b3868b495d62c5f7b1a124044b2b9293ec4867fc2c77c822e13f090e8c6502ecbbc3349af794e45c6fc8a9823728bcc3b482bf82b4a954f8a7bc1981e1be4877b62311084c50fd95cae06ae200e", EncodeUtils.bytesToHex(encodedSignature));
            //Assert.assertEquals("d901f0625dee0a65ce6dc0430a1454d41d0b0c4603cd932605e61880abc2a2af7e25122b353444343144304230433436303343443933323630354536313838304142433241324146374532352d31351a0b4e4e422d3237345f424e4220022802308084af5f3880dea0cb054001126c0a26eb5ae987210216087947712ad02e55bf34a227974644f5a6cca391771b3868b495d62c5f7b1a124044b2b9293ec4867fc2c77c822e13f090e8c6502ecbbc3349af794e45c6fc8a9823728bcc3b482bf82b4a954f8a7bc1981e1be4877b62311084c50fd95cae06ae200e", EncodeUtils.bytesToHex(assembler.encodeStdTx(encodedMsg, encodedSignature)));

            string build = assembler.BuildNewOrder(newOrder);
            Assert.Equal("d901f0625dee0a65ce6dc0430a1454d41d0b0c4603cd932605e61880abc2a2af7e25122b353444343144304230433436303343443933323630354536313838304142433241324146374532352d31351a0b4e4e422d3237345f424e4220022802308084af5f3880dea0cb054001126c0a26eb5ae987210216087947712ad02e55bf34a227974644f5a6cca391771b3868b495d62c5f7b1a124044b2b9293ec4867fc2c77c822e13f090e8c6502ecbbc3349af794e45c6fc8a9823728bcc3b482bf82b4a954f8a7bc1981e1be4877b62311084c50fd95cae06ae200e", build, true);
        }

        [Fact]
        public void CancelOrderTest()
        {
            //List<String> words = Arrays.asList("slot live best metal mandate page hover tank bronze code salad hill hen salad train inmate autumn nut home city shield level board measure".split(" "));
            //Wallet wallet = Wallet.createWalletFromMnemonicCode(words, BinanceDexEnvironment.TEST_NET);
            Wallet wallet = new Wallet("db923c5e1b5b2db221da5d14bdc41c5fb3c15510bf1fb2bc8faf33679dd85e54", BinanceDexEnvironment.TEST_NET);
            Assert.Equal("tbnb12n2p6zcvgcpumyexqhnp3q9tc2327l39ycfnyk", wallet.Address);

            wallet.AccountNumber = 0;
            wallet.Sequence = 14L;
            wallet.ChainId = "test-chain-n4b735";

            TransactionOption options = new TransactionOption { Memo = "", Source = 0, Data = null };
            TransactionRequest assembler = new TransactionRequest(wallet, options);

            CancelOrder cancelOrder = new CancelOrder()
            {
                Symbol = "NNB-274_BNB",
                RefId = "54D41D0B0C4603CD932605E61880ABC2A2AF7E25-14"
            };

            //CancelOrderMessage msgBean = assembler.createCancelOrderMessage(co);
            //byte[] encodedMsg = assembler.encodeCancelOrderMessage(msgBean);
            //Assert.assertEquals("166e681b0a1454d41d0b0c4603cd932605e61880abc2a2af7e25120b4e4e422d3237345f424e421a2b353444343144304230433436303343443933323630354536313838304142433241324146374532352d3134", EncodeUtils.bytesToHex(encodedMsg));
            //byte[] signature = assembler.sign(msgBean);
            //Assert.assertEquals("c0d9a95bf30e74d0701e4033c419020dbbac4b282356183caba98af0d57fdc583ddb3ada2a9961d75d175cbc7ced39225c0e14a0c0667b805f522a3c498d38a7".toLowerCase(), EncodeUtils.bytesToHex(signature));
            //byte[] encodedSignature = assembler.encodeSignature(signature);

            //Assert.assertEquals("0a26eb5ae987210216087947712ad02e55bf34a227974644f5a6cca391771b3868b495d62c5f7b1a1240c0d9a95bf30e74d0701e4033c419020dbbac4b282356183caba98af0d57fdc583ddb3ada2a9961d75d175cbc7ced39225c0e14a0c0667b805f522a3c498d38a7200e", EncodeUtils.bytesToHex(encodedSignature));
            //Assert.assertEquals("c801f0625dee0a54166e681b0a1454d41d0b0c4603cd932605e61880abc2a2af7e25120b4e4e422d3237345f424e421a2b353444343144304230433436303343443933323630354536313838304142433241324146374532352d3134126c0a26eb5ae987210216087947712ad02e55bf34a227974644f5a6cca391771b3868b495d62c5f7b1a1240c0d9a95bf30e74d0701e4033c419020dbbac4b282356183caba98af0d57fdc583ddb3ada2a9961d75d175cbc7ced39225c0e14a0c0667b805f522a3c498d38a7200e", EncodeUtils.bytesToHex(assembler.encodeStdTx(encodedMsg, encodedSignature)));

            string build = assembler.BuildCancelOrder(cancelOrder);
            Assert.Equal("c801f0625dee0a54166e681b0a1454d41d0b0c4603cd932605e61880abc2a2af7e25120b4e4e422d3237345f424e421a2b353444343144304230433436303343443933323630354536313838304142433241324146374532352d3134126c0a26eb5ae987210216087947712ad02e55bf34a227974644f5a6cca391771b3868b495d62c5f7b1a1240c0d9a95bf30e74d0701e4033c419020dbbac4b282356183caba98af0d57fdc583ddb3ada2a9961d75d175cbc7ced39225c0e14a0c0667b805f522a3c498d38a7200e", build, true);
        }

        [Fact]
        public void TokenFreezeTest()
        {
            //List<String> words = Arrays.asList("trial raw kiss bench silent crystal clever cloud chapter obvious error income mechanic attend army outer found cube tribe sort south possible scene fox".split(" "));
            //Wallet wallet = Wallet.createWalletFromMnemonicCode(words, BinanceDexEnvironment.TEST_NET);
            Wallet wallet = new Wallet("84c4226a24732e2d832e9d932779adfb9b95401ee607086967c7c5bba1e3a18e", BinanceDexEnvironment.TEST_NET);
            Assert.Equal("tbnb1mrslq6lhglm3jp7pxzlk8u4549pmtp9sgvn2rc", wallet.Address);

            wallet.AccountNumber = 0;
            wallet.Sequence = 9L;
            wallet.ChainId = "test-chain-n4b735";

            TransactionOption options = new TransactionOption { Memo = "", Source = 0, Data = null };
            TransactionRequest assembler = new TransactionRequest(wallet, options);

            TokenFreeze tokenFreeze = new TokenFreeze()
            {
                Amount = "1",
                Symbol = "NNB-C3F"
            };

            //TokenFreezeMessage msgBean = assembler.createTokenFreezeMessage(tf);
            //byte[] encodedMsg = assembler.encodeTokenFreezeMessage(msgBean);
            //Assert.assertEquals("e774b32d0a14d8e1f06bf747f71907c130bf63f2b4a943b584b012074e4e422d4333461880c2d72f", EncodeUtils.bytesToHex(encodedMsg));
            //byte[] signature = assembler.sign(msgBean);
            //Assert.assertEquals("9ceabe0262a75b0da7556303580f56a094486cc9938a728f903a57054061bd833288979fbc8dc5ee07743df5110cb773c25d9974f34158a4f6ed6ac6899740c2".toLowerCase(), EncodeUtils.bytesToHex(signature));
            //byte[] encodedSignature = assembler.encodeSignature(signature);

            //Assert.assertEquals("0a26eb5ae987210280ec8943329305e43b2e6112728423ef9f9a7e7125621c3545c2f30ce08bf83c12409ceabe0262a75b0da7556303580f56a094486cc9938a728f903a57054061bd833288979fbc8dc5ee07743df5110cb773c25d9974f34158a4f6ed6ac6899740c22009", EncodeUtils.bytesToHex(encodedSignature));
            //Assert.assertEquals( "9c01f0625dee0a28e774b32d0a14d8e1f06bf747f71907c130bf63f2b4a943b584b012074e4e422d4333461880c2d72f126c0a26eb5ae987210280ec8943329305e43b2e6112728423ef9f9a7e7125621c3545c2f30ce08bf83c12409ceabe0262a75b0da7556303580f56a094486cc9938a728f903a57054061bd833288979fbc8dc5ee07743df5110cb773c25d9974f34158a4f6ed6ac6899740c22009", EncodeUtils.bytesToHex(assembler.encodeStdTx(encodedMsg, encodedSignature)));

            string build = assembler.BuildTokenFreeze(tokenFreeze);
            Assert.Equal("9c01f0625dee0a28e774b32d0a14d8e1f06bf747f71907c130bf63f2b4a943b584b012074e4e422d4333461880c2d72f126c0a26eb5ae987210280ec8943329305e43b2e6112728423ef9f9a7e7125621c3545c2f30ce08bf83c12409ceabe0262a75b0da7556303580f56a094486cc9938a728f903a57054061bd833288979fbc8dc5ee07743df5110cb773c25d9974f34158a4f6ed6ac6899740c22009", build, true);
        }

        [Fact]
        public void TokenUnfreezeTest()
        {
            //List<String> words = Arrays.asList("trial raw kiss bench silent crystal clever cloud chapter obvious error income mechanic attend army outer found cube tribe sort south possible scene fox".split(" "));
            //Wallet wallet = Wallet.createWalletFromMnemonicCode(words, BinanceDexEnvironment.TEST_NET);
            Wallet wallet = new Wallet("84c4226a24732e2d832e9d932779adfb9b95401ee607086967c7c5bba1e3a18e", BinanceDexEnvironment.TEST_NET);
            Assert.Equal("tbnb1mrslq6lhglm3jp7pxzlk8u4549pmtp9sgvn2rc", wallet.Address);

            wallet.AccountNumber = 0;
            wallet.Sequence = 9L;
            wallet.ChainId = "test-chain-n4b735";

            TransactionOption options = new TransactionOption { Memo = "", Source = 0, Data = null };
            TransactionRequest assembler = new TransactionRequest(wallet, options);

            TokenUnfreeze tokenUnfreeze = new TokenUnfreeze()
            {
                Amount = "1",
                Symbol = "NNB-C3F"
            };

            //TokenUnfreezeMessage msgBean = assembler.createTokenUnfreezeMessage(tu);
            //byte[] encodedMsg = assembler.encodeTokenUnfreezeMessage(msgBean);
            //Assert.assertEquals("6515ff0d0a14d8e1f06bf747f71907c130bf63f2b4a943b584b012074e4e422d4333461880c2d72f", EncodeUtils.bytesToHex(encodedMsg));
            //byte[] signature = assembler.sign(msgBean);
            //Assert.assertEquals("9ceabe0262a75b0da7556303580f56a094486cc9938a728f903a57054061bd833288979fbc8dc5ee07743df5110cb773c25d9974f34158a4f6ed6ac6899740c2".toLowerCase(), EncodeUtils.bytesToHex(signature));
            //byte[] encodedSignature = assembler.encodeSignature(signature);
            //Assert.assertEquals("0a26eb5ae987210280ec8943329305e43b2e6112728423ef9f9a7e7125621c3545c2f30ce08bf83c12409ceabe0262a75b0da7556303580f56a094486cc9938a728f903a57054061bd833288979fbc8dc5ee07743df5110cb773c25d9974f34158a4f6ed6ac6899740c22009", EncodeUtils.bytesToHex(encodedSignature));
            //Assert.assertEquals("9c01f0625dee0a286515ff0d0a14d8e1f06bf747f71907c130bf63f2b4a943b584b012074e4e422d4333461880c2d72f126c0a26eb5ae987210280ec8943329305e43b2e6112728423ef9f9a7e7125621c3545c2f30ce08bf83c12409ceabe0262a75b0da7556303580f56a094486cc9938a728f903a57054061bd833288979fbc8dc5ee07743df5110cb773c25d9974f34158a4f6ed6ac6899740c22009", EncodeUtils.bytesToHex(assembler.encodeStdTx(encodedMsg, encodedSignature)));

            string build = assembler.BuildTokenUnfreeze(tokenUnfreeze);
            Assert.Equal("9c01f0625dee0a286515ff0d0a14d8e1f06bf747f71907c130bf63f2b4a943b584b012074e4e422d4333461880c2d72f126c0a26eb5ae987210280ec8943329305e43b2e6112728423ef9f9a7e7125621c3545c2f30ce08bf83c12409ceabe0262a75b0da7556303580f56a094486cc9938a728f903a57054061bd833288979fbc8dc5ee07743df5110cb773c25d9974f34158a4f6ed6ac6899740c22009", build, true);
        }

        [Fact]
        public void VoteTest()
        {
            //List<String> words = Arrays.asList("trial raw kiss bench silent crystal clever cloud chapter obvious error income mechanic attend army outer found cube tribe sort south possible scene fox".split(" "));
            //Wallet wallet = Wallet.createWalletFromMnemonicCode(words, BinanceDexEnvironment.TEST_NET);
            Wallet wallet = new Wallet("84c4226a24732e2d832e9d932779adfb9b95401ee607086967c7c5bba1e3a18e", BinanceDexEnvironment.TEST_NET);
            Assert.Equal("tbnb1mrslq6lhglm3jp7pxzlk8u4549pmtp9sgvn2rc", wallet.Address);

            wallet.AccountNumber = 0;
            wallet.Sequence = 9L;
            wallet.ChainId = "test-chain-n4b735";

            TransactionOption options = new TransactionOption { Memo = "", Source = 0, Data = null };
            TransactionRequest assembler = new TransactionRequest(wallet, options);

            Vote vote = new Vote()
            {
                ProposalId = 347,
                Option = 1
            };

            //VoteMessage voteMessage = assembler.createVoteMessage(vote);
            //byte[] encodedMsg = assembler.encodeVoteMessage(voteMessage);
            //Assert.Equal("a1cadd3608db021214d8e1f06bf747f71907c130bf63f2b4a943b584b01801", EncodeUtils.bytesToHex(encodedMsg));
            //byte[] signature = assembler.sign(voteMessage);
            //Assert.Equal("37f4f39cf414461c478f166a2d59705dd8566fd573214c5c002a075d6a6d86c237d6f237c35983d001e4b322b1d0f9cef9328d670f163600e3af2226792c4b16".toLowerCase(), EncodeUtils.bytesToHex(signature));
            //byte[] encodedSignature = assembler.encodeSignature(signature);
            //Assert.Equal("0a26eb5ae987210280ec8943329305e43b2e6112728423ef9f9a7e7125621c3545c2f30ce08bf83c124037f4f39cf414461c478f166a2d59705dd8566fd573214c5c002a075d6a6d86c237d6f237c35983d001e4b322b1d0f9cef9328d670f163600e3af2226792c4b162009", EncodeUtils.bytesToHex(encodedSignature));
            //Assert.Equal("9301f0625dee0a1fa1cadd3608db021214d8e1f06bf747f71907c130bf63f2b4a943b584b01801126c0a26eb5ae987210280ec8943329305e43b2e6112728423ef9f9a7e7125621c3545c2f30ce08bf83c124037f4f39cf414461c478f166a2d59705dd8566fd573214c5c002a075d6a6d86c237d6f237c35983d001e4b322b1d0f9cef9328d670f163600e3af2226792c4b162009", EncodeUtils.bytesToHex(assembler.encodeStdTx(encodedMsg, encodedSignature)));

            string build = assembler.BuildVote(vote);
            Assert.Equal("9301f0625dee0a1fa1cadd3608db021214d8e1f06bf747f71907c130bf63f2b4a943b584b01801126c0a26eb5ae987210280ec8943329305e43b2e6112728423ef9f9a7e7125621c3545c2f30ce08bf83c124037f4f39cf414461c478f166a2d59705dd8566fd573214c5c002a075d6a6d86c237d6f237c35983d001e4b322b1d0f9cef9328d670f163600e3af2226792c4b162009", build, true);
        }
    }
}