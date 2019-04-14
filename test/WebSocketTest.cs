using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace binance.dex.sdk.test
{
    public class WebSocketTest
    {
        [Fact]
        public void ConnectTest()
        {
            //string url = BinanceDexEnvironment.TEST_NET.WsBaseUrl;
            string url = "wss://testnet-dex.binance.org/api/ws/$all@blockheight";
        }
    }
}
