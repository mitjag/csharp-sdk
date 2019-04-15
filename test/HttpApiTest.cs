using binance.dex.sdk.broadcast;
using binance.dex.sdk.crypto;
using binance.dex.sdk.httpapi;
using binance.dex.sdk.message;
using binance.dex.sdk.model;
using RestSharp.Deserializers;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace binance.dex.sdk.test
{
    public class HttpApiTest
    {
        [Fact]
        public void TimeTest()
        {
            /*Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .CreateLogger();*/
            
            HttpApiClient client = new HttpApiClient(BinanceDexEnvironment.TEST_NET);
            var time = client.Time();
            Assert.NotNull(time);
        }

        [Fact]
        public void NodeInfoTest()
        {
            HttpApiClient client = new HttpApiClient(BinanceDexEnvironment.TEST_NET);
            var infos = client.NodeInfo();
            Assert.NotNull(infos);
        }

        [Fact]
        public void ValidatorsTest()
        {
            HttpApiClient client = new HttpApiClient(BinanceDexEnvironment.TEST_NET);
            var validatorInfo = client.Validators();
            Assert.NotNull(validatorInfo);
        }

        [Fact]
        public void PeersTest()
        {
            HttpApiClient client = new HttpApiClient(BinanceDexEnvironment.TEST_NET);
            var peers = client.Peers();
            Assert.NotNull(peers);
        }

        [Fact]
        public void AccountTest()
        {
            string response = "{\"address\":\"tbnb1qn2w8mjmykelskltc8w9zy03q8sg7k9wllp9gu\",\"public_key\":[3,190,175,3,37,43,147,174,93,119,217,166,11,141,65,222,224,101,224,32,174,83,140,243,3,30,22,207,186,116,42,18,50],\"account_number\":80849,\"sequence\":27,\"balances\":[{\"symbol\":\"AAS-361\",\"free\":\"2291.77308832\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"DC1-4B8\",\"free\":\"0.01826704\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"NMSL-19D\",\"free\":\"229.17592919\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"SCM-CDF\",\"free\":\"27.50111150\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"SLC-6D1\",\"free\":\"463.96607480\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"ZEBRA-16D\",\"free\":\"149.47592919\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"AAAAAA-BBA\",\"free\":\"0.02291759\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"AVT-B74\",\"free\":\"0.02280343\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"IGG-013\",\"free\":\"0.09448420\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"KOGE48-35D\",\"free\":\"231.98841913\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"XXX77-EDC\",\"free\":\"0.04611856\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"CZCOIN-33B\",\"free\":\"506259.71133965\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"IFF-804\",\"free\":\"30.09448420\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"IHH-D4E\",\"free\":\"0.09448420\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"OCB-75B\",\"free\":\"463.97683827\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"PND-943\",\"free\":\"122.10011150\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"SENT-730\",\"free\":\"3200.66573847\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"UKT-710\",\"free\":\"1898.93849338\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"AGRI-BD2\",\"free\":\"1028.42693026\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"ASTRO-F7B\",\"free\":\"240.04993038\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"IJJ-65E\",\"free\":\"0.09448420\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"MBNB-113\",\"free\":\"2291.75929193\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"OEN-FD1\",\"free\":\"22917.63873164\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"TC1-F43\",\"free\":\"0.01826704\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"UDO-638\",\"free\":\"50.41308481\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"WIN-AB8\",\"free\":\"229.17592919\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"WWW76-A8F\",\"free\":\"0.04611856\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"BEY-8C6\",\"free\":\"0.03175238\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"CR7-4CC\",\"free\":\"2291.75929193\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"DEC-237\",\"free\":\"379.78769867\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"III-25C\",\"free\":\"0.09448420\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"OCB-B95\",\"free\":\"0.00000419\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"RUS-FA1\",\"free\":\"5080.68185065\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"SEX-DA3\",\"free\":\"100.00000000\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"BNB\",\"free\":\"133.35149200\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"FLC-FB2\",\"free\":\"320.06657384\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"MGT-3F0\",\"free\":\"4141.62517371\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"NC1-279\",\"free\":\"0.01826704\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"NC2-249\",\"free\":\"0.01411566\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"PIC-F40\",\"free\":\"1028.42693026\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"YLC-D8B\",\"free\":\"1.05301288\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"CELR-42B\",\"free\":\"22917.59291938\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"LC1-7FC\",\"free\":\"0.01826704\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"RC1-A1E\",\"free\":\"0.01826704\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"TC1-A29\",\"free\":\"0.01826704\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"YYY78-BCD\",\"free\":\"0.04611856\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"TFA-3B4\",\"free\":\"0.05731324\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"100K-9BC\",\"free\":\"0.23198841\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"10KONLY-2C1\",\"free\":\"0.02300902\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"COSMOS-587\",\"free\":\"1120.83748977\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"FBB-E03\",\"free\":\"229.17592919\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"MEME-93C\",\"free\":\"0.75542051\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"RC1-943\",\"free\":\"0.01826704\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"SVC-A14\",\"free\":\"0.18267042\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"000-EF6\",\"free\":\"0.15876191\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"DGB-5FB\",\"free\":\"2291.75929652\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"RBT-CB7\",\"free\":\"0.01008261\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"ZANKU-CCA\",\"free\":\"0.01844742\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"AAA-EB8\",\"free\":\"458.35185838\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"BC1-3A1\",\"free\":\"0.01826704\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"FCT-B60\",\"free\":\"4141.62517371\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"GANJA-880\",\"free\":\"966.37920720\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"ICC-6EF\",\"free\":\"0.09448420\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"MLC-DB2\",\"free\":\"2291.75929193\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"NFT-7EE\",\"free\":\"1587.81280065\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"GCC-8F6\",\"free\":\"229.17592919\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"TGT-9FC\",\"free\":\"332.51102828\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"XSX-072\",\"free\":\"0.10228149\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"ALIS-95B\",\"free\":\"0.01008261\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"CAT-F9B\",\"free\":\"1898.93849338\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"DUIT-31C\",\"free\":\"1211.12394964\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"SCARCE-967\",\"free\":\"0.46397683\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"UCX-CC8\",\"free\":\"0.08859649\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"ZZZ-21E\",\"free\":\"0.13988596\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"007-749\",\"free\":\"0.00087619\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"BTMGL-C72\",\"free\":\"2045.62981873\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"JAGER-162\",\"free\":\"64.70426244\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"LCQ-AC5\",\"free\":\"91.33568718\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"MFH-9B5\",\"free\":\"21163.29490475\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"CZC-D63\",\"free\":\"320.06657384\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"E0C-EF8\",\"free\":\"320.06657384\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"IEE-DCA\",\"free\":\"0.09448420\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"IDD-516\",\"free\":\"0.09448420\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"MC1-3A8\",\"free\":\"0.01826704\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"SATOSHI-C92\",\"free\":\"206258.33627442\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"JDWK-C81\",\"free\":\"2.29175929\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"000-0E1\",\"free\":\"0.00021060\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"AAD-E18\",\"free\":\"2291.75975028\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"DCC-52A\",\"free\":\"230.09028742\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"EDU-DD0\",\"free\":\"1.39885964\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"FRI-D5F\",\"free\":\"112.51373129\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"IAA-C81\",\"free\":\"0.09448420\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"IBB-8DE\",\"free\":\"0.09448420\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"NC1-F63\",\"free\":\"0.00112083\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"PPC-00A\",\"free\":\"243.19649628\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"},{\"symbol\":\"ZZZ79-3C4\",\"free\":\"0.04611856\",\"locked\":\"0.00000000\",\"frozen\":\"0.00000000\"}]}\n";
            Account acc = Newtonsoft.Json.JsonConvert.DeserializeObject<Account>(response);

            HttpApiClient httpApiClient = new HttpApiClient(BinanceDexEnvironment.TEST_NET);
            Wallet wallet = new Wallet("6d3cfc67595db1523915219718a31fa5b467d099a51035d8fb82ea9841496f09", BinanceDexEnvironment.TEST_NET);
            Account account = httpApiClient.Account(wallet.Address);
            Assert.NotEqual(0, account.AccountNumber);
        }

        [Fact]
        public void AccountSequenceTest()
        {
            HttpApiClient httpApiClient = new HttpApiClient(BinanceDexEnvironment.TEST_NET);
            Wallet wallet = new Wallet("6d3cfc67595db1523915219718a31fa5b467d099a51035d8fb82ea9841496f09", BinanceDexEnvironment.TEST_NET);
            var accountSequence = httpApiClient.AccountSequence(wallet.Address);
            Assert.NotEqual(0, accountSequence.Sequence);
        }

        [Fact]
        public void TxTest()
        {
            HttpApiClient httpApiClient = new HttpApiClient(BinanceDexEnvironment.TEST_NET);
            Transaction transaction = httpApiClient.Tx("D726ACEEE1AC98815A206EBEB2EE0280BFAE6EEB53A0E3F564175443E31B8A5D");
            Assert.True(transaction.Ok);
        }

        [Fact]
        public void TokensTest()
        {
            HttpApiClient httpApiClient = new HttpApiClient(BinanceDexEnvironment.TEST_NET);
            List<model.Token> tokens = httpApiClient.Tokens(500, 0);
            Assert.NotEmpty(tokens);
        }

        [Fact]
        public void MarketsTest()
        {
            HttpApiClient httpApiClient = new HttpApiClient(BinanceDexEnvironment.TEST_NET);
            List<Market> markets = httpApiClient.Markets();
            Assert.NotEmpty(markets);
        }

        [Fact]
        public void FeesTest()
        {
            HttpApiClient httpApiClient = new HttpApiClient(BinanceDexEnvironment.TEST_NET);
            List<FeeData> fees = httpApiClient.Fees();
            Assert.NotEmpty(fees);
        }

        [Fact]
        public void DepthTest()
        {
            HttpApiClient httpApiClient = new HttpApiClient(BinanceDexEnvironment.TEST_NET);
            MarketDepth marketDepth = httpApiClient.Depth("PND-943_BNB");
            Assert.NotNull(marketDepth);
        }

        [Fact]
        public void BroadcastTest()
        {
            HttpApiClient httpApiClient = new HttpApiClient(BinanceDexEnvironment.TEST_NET);
            Wallet wallet = new Wallet(
                "6d3cfc67595db1523915219718a31fa5b467d099a51035d8fb82ea9841496f09",
                BinanceDexEnvironment.TEST_NET);

            Transfer transfer = new Transfer
            {
                Coin = "PND-943",
                FromAddress = wallet.Address,
                ToAddress = "tbnb18086qc9yxtk5ufddple8upf0k3072vvagpm2ml",
                Amount = "0.05"
            };

            TransactionRequest assmebler = new TransactionRequest(wallet, TransactionOption.DefaultInstace);
            string body = assmebler.BuildTransfer(transfer);
            List<TransactionMetadata> result = httpApiClient.Broadcast(body);
            foreach (TransactionMetadata metadata in result)
            {
                Assert.True(metadata.Ok);
            }
        }

        [Fact]
        public void KLinesTest()
        {
            HttpApiClient httpApiClient = new HttpApiClient(BinanceDexEnvironment.TEST_NET);
            List<List<object>> klines  = httpApiClient.KLines("PND-943_BNB", "5m");
            Assert.NotEmpty(klines);
        }
    }
}
