using binance.dex.sdk.wallet;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace binance.dex.sdk.test
{
    public class WalletTest
    {
        [Fact]
        public void AddressTest()
        {
            Wallet wallet = new Wallet("6d3cfc67595db1523915219718a31fa5b467d099a51035d8fb82ea9841496f09", BinanceDexEnvironment.TEST_NET);
            Assert.Equal("tbnb1qn2w8mjmykelskltc8w9zy03q8sg7k9wllp9gu", wallet.Address);

            //address: tbnb1qn2w8mjmykelskltc8w9zy03q8sg7k9wllp9gu private key: 6d3cfc67595db1523915219718a31fa5b467d099a51035d8fb82ea9841496f09
            //code: tzqglz xuftjl jwsotf naeepf suosvr lcfzvi xgtahd cagrdb rpmszl rcvuxv eiwxkg pmxmev bfyank qgnefz iijyid obmmvc ntzodt qopfnt vrvxfx fqujnx tgtsli zbbled chbtjf srbezi
        }
    }
}
