using binance.dex.sdk.websocket;
using binance.dex.sdk.websocket.stream;
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
            //string url = "wss://testnet-dex.binance.org/api/ws/$all@blockheight";
            WebSocketClient client = new WebSocketClient();
            client.Env = BinanceDexEnvironment.TEST_NET;
            client.Topic = ETopic.Blockheight;
            client.StreamData += Client_StreamData;
            client.Connect();
        }

        private void Client_StreamData(object sender, IStreamData data)
        {
            Blockheight blockheight = (Blockheight)data;
        }
    }
}
