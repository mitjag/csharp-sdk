using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket.stream
{
    public class EMethod
    {
        public const string KeepAlive = "keepAlive";
        public const string Close = "close";
        public const string Subscribe = "subscribe";
        public const string Unsubscribe = "unsubscribe";
    }

    public class ETopic
    {
        public const string Orders = "orders";
        public const string MarketDepth = "marketDepth";
    }

    public class Send
    {

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("symbols")]
        public List<string> Symbols { get; set; }
    }
}
