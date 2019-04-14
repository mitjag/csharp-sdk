using System;
using System.Collections.Generic;
using System.Text;
using WebSocketSharp;
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
            Console.WriteLine("Biance DEX chain");
            using (var ws = new WebSocket(url))
            {
                ws.OnMessage += (sender, e) => Console.WriteLine("Biance DEX chain: " + e.Data);
                ws.Connect();
                //ws.Send(@"{""method"":""close""}");
            }
            string s = "123";
        }
    }
}
