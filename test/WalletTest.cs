using binance.dex.sdk.crypto;
using NBitcoin;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Text;
using Xunit;

namespace binance.dex.sdk.test
{
    public class WalletTest
    {
        [Fact]
        public void AddressTest()
        {
            Wallet wallet = Wallet.FromPrivateKey("6d3cfc67595db1523915219718a31fa5b467d099a51035d8fb82ea9841496f09", BinanceDexEnvironment.TEST_NET);
            Assert.Equal("tbnb1qn2w8mjmykelskltc8w9zy03q8sg7k9wllp9gu", wallet.Address);

            //address: tbnb1qn2w8mjmykelskltc8w9zy03q8sg7k9wllp9gu private key: 6d3cfc67595db1523915219718a31fa5b467d099a51035d8fb82ea9841496f09
            //code: tzqglz xuftjl jwsotf naeepf suosvr lcfzvi xgtahd cagrdb rpmszl rcvuxv eiwxkg pmxmev bfyank qgnefz iijyid obmmvc ntzodt qopfnt vrvxfx fqujnx tgtsli zbbled chbtjf srbezi
        }

        [Fact]
        public void AddressTest2()
        {
            Wallet wallet = Wallet.FromPrivateKey("f0e87ed55fa3d86f62b38b405cbb5f732764a7d5bc690da45a32aa3f2fc81a36", BinanceDexEnvironment.TEST_NET);
            Assert.Equal("tbnb18086qc9yxtk5ufddple8upf0k3072vvagpm2ml", wallet.Address);
        }

        [Fact]
        public void WordsTest()
        {
            string words = "slot live best metal mandate page hover tank bronze code salad hill hen salad train inmate autumn nut home city shield level board measure";
            Wallet wallet1 = Wallet.FromMnemonicCode(words, BinanceDexEnvironment.TEST_NET);
            Wallet wallet2 = Wallet.FromPrivateKey("db923c5e1b5b2db221da5d14bdc41c5fb3c15510bf1fb2bc8faf33679dd85e54", BinanceDexEnvironment.TEST_NET);
            string address = "tbnb12n2p6zcvgcpumyexqhnp3q9tc2327l39ycfnyk";
            Assert.Equal(address, wallet1.Address);
            Assert.Equal(address, wallet2.Address);
        }

        [Fact]
        public void RandomWordsTest()
        {
            Mnemonic mnemonic = new Mnemonic(Wordlist.English, WordCount.TwentyFour);
            string mnemonicCode = mnemonic.ToString();
            Assert.Equal(24, mnemonicCode.Split(' ').Length);
        }
    }
}
