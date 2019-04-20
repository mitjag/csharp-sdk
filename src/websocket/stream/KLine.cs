using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket.stream
{
    public class K
    {
        /*
            {
                "t": 123400000,     // Kline start time
                "T": 123460000,     // Kline close time
                "s": "BNBBTC",      // Symbol
                "i": "1m",          // Interval
                "f": "100",         // First trade ID
                "L": "200",         // Last trade ID
                "o": "0.0010",      // Open price
                "c": "0.0020",      // Close price
                "h": "0.0025",      // High price
                "l": "0.0015",      // Low price
                "v": "1000",        // Base asset volume
                "n": 100,           // Number of trades
                "x": false,         // Is this kline closed?
                "q": "1.0000",      // Quote asset volume
            }
        */

        /// <summary>
        /// Kline start time
        /// </summary>
        [JsonProperty("t")]
        public long KlineStartTime { get; set; }

        /// <summary>
        /// Kline close time
        /// </summary>
        [JsonProperty("T")]
        public long KlineCloseTime { get; set; }

        /// <summary>
        /// Symbol
        /// </summary>
        [JsonProperty("s")]
        public string Symbol { get; set; }

        /// <summary>
        /// Interval
        /// </summary>
        [JsonProperty("i")]
        public string Interval { get; set; }

        /// <summary>
        /// First trade ID
        /// </summary>
        [JsonProperty("f")]
        public string FirstTradeID { get; set; }

        /// <summary>
        /// Last trade ID
        /// </summary>
        [JsonProperty("L")]
        public string LastTradeID { get; set; }

        /// <summary>
        /// Open price
        /// </summary>
        [JsonProperty("o")]
        public string OpenPrice { get; set; }

        /// <summary>
        /// Close price
        /// </summary>
        [JsonProperty("c")]
        public string ClosePrice { get; set; }

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
        /// Base asset volume
        /// </summary>
        [JsonProperty("v")]
        public string BaseAssetVolume { get; set; }

        /// <summary>
        /// Number of trades
        /// </summary>
        [JsonProperty("n")]
        public long NumberOfTrades { get; set; }

        /// <summary>
        /// Is this kline closed?
        /// </summary>
        [JsonProperty("x")]
        public bool IsClosed { get; set; }

        /// <summary>
        /// Quote asset volume
        /// </summary>
        [JsonProperty("q")]
        public string QuoteAssetVolume { get; set; }
    }

    public class KLine : IStreamData
    {
        /*
         {
            "e": "kline",         // Event type
            "E": 123456789,       // Event time
            "s": "BNBBTC",        // Symbol
            "k": {
              "t": 123400000,     // Kline start time
              "T": 123460000,     // Kline close time
              "s": "BNBBTC",      // Symbol
              "i": "1m",          // Interval
              "f": "100",         // First trade ID
              "L": "200",         // Last trade ID
              "o": "0.0010",      // Open price
              "c": "0.0020",      // Close price
              "h": "0.0025",      // High price
              "l": "0.0015",      // Low price
              "v": "1000",        // Base asset volume
              "n": 100,           // Number of trades
              "x": false,         // Is this kline closed?
              "q": "1.0000",      // Quote asset volume
            }
          }
         */

        public ETopic Topic { get { return ETopic.KLine; } }

        /// <summary>
        /// Event time
        /// </summary>
        [JsonProperty("E")]
        public long EventTime { get; set; }

        /// <summary>
        /// Event type
        /// </summary>
        [JsonProperty("E")]
        public string EventType { get; set; }

        /// <summary>
        /// Symbol
        /// </summary>
        [JsonProperty("s")]
        public string Symbol { get; set; }

        /// <summary>
        /// Event type
        /// </summary>
        [JsonProperty("k")]
        public K K { get; set; }
    }
}
