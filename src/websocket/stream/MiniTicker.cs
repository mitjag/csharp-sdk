using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket.stream
{
    public class MiniTicker : IStreamData
    {
        /*
            {
                "e": "24hrMiniTicker",    // Event type
                "E": 123456789,           // Event time
                "s": "BNBBTC",            // Symbol
                "c": "0.0025",            // Current day's close price
                "o": "0.0010",            // Open price
                "h": "0.0025",            // High price
                "l": "0.0010",            // Low price
                "v": "10000",             // Total traded base asset volume
                "q": "18",                // Total traded quote asset volume
            }
         */

        public ETopic Topic { get { return ETopic.MiniTicker; } }

        /// <summary>
        /// Event type
        /// </summary>
        [JsonProperty("e")]
        public string EventType { get; set; }

        /// <summary>
        /// Event time
        /// </summary>
        [JsonProperty("E")]
        public long EventTime { get; set; }

        /// <summary>
        /// Symbol
        /// </summary>
        [JsonProperty("s")]
        public string Symbol { get; set; }

        /// <summary>
        /// Current day's close price
        /// </summary>
        [JsonProperty("c")]
        public string CurrentDaysClosePrice { get; set; }

        /// <summary>
        /// Open price
        /// </summary>
        [JsonProperty("o")]
        public string OpenPrice { get; set; }

        /// <summary>
        /// High price
        /// </summary>
        [JsonProperty("h")]
        public string HighPrice { get; set; }

        /// <summary>
        /// Low price
        /// </summary>
        [JsonProperty("l")]
        public string LowPrice { get; set; }

        /// <summary>
        /// Total traded base asset volume
        /// </summary>
        [JsonProperty("v")]
        public string TotalTradedBaseAssetVolume { get; set; }

        /// <summary>
        /// Total traded quote asset volume
        /// </summary>
        [JsonProperty("q")]
        public string TotalTradedQuoteAssetVolume { get; set; }
    }
}
