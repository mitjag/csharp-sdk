using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk
{
    public static class BinanceDexEnvironment
    {
        private const string PROD_BASE_URL = "https://dex.binance.org";
        private const string PROD_WS_BASE_URL = "wss://dex.binance.org/api/";

        private const string TEST_NET_BASE_URL = "https://testnet-dex.binance.org";
        private const string TEST_NET_WS_BASE_URL = "wss://testnet-dex.binance.org/api/";

        public static BinanceDexEnvironmentData PROD => new BinanceDexEnvironmentData(PROD_BASE_URL, PROD_WS_BASE_URL, "bnb");
        public static BinanceDexEnvironmentData TEST_NET => new BinanceDexEnvironmentData(TEST_NET_BASE_URL, TEST_NET_WS_BASE_URL, "tbnb");
    }

    public class BinanceDexEnvironmentData {

        // Rest API base URL
        public string BaseUrl { get; set; }
        // Websocket API base URL
        public string WsBaseUrl { get; set; }
        // Address human readable part prefix
        public string Hrp { get; set; }

        public BinanceDexEnvironmentData(string baseUrl, string wsBaseUrl, string hrp)
        {
            BaseUrl = baseUrl;
            WsBaseUrl = wsBaseUrl;
            Hrp = hrp;
        }
    }
}
