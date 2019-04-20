using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket.stream
{
    public class Ticker : IStreamData
    {
        /*
             {
                "e": "24hrTicker",  // Event type
                "E": 123456789,     // Event time
                "s": "BNBBTC",      // Symbol
                "p": "0.0015",      // Price change
                "P": "250.00",      // Price change percent
                "w": "0.0018",      // Weighted average price
                "x": "0.0009",      // Previous day's close price
                "c": "0.0025",      // Current day's close price
                "Q": "10",          // Close trade's quantity
                "b": "0.0024",      // Best bid price
                "B": "10",          // Best bid quantity
                "a": "0.0026",      // Best ask price
                "A": "100",         // Best ask quantity
                "o": "0.0010",      // Open price
                "h": "0.0025",      // High price
                "l": "0.0010",      // Low price
                "v": "10000",       // Total traded base asset volume
                "q": "18",          // Total traded quote asset volume
                "O": 0,             // Statistics open time
                "C": 86400000,      // Statistics close time
                "F": "0",           // First trade ID
                "L": "18150",       // Last trade Id
                "n": 18151          // Total number of trades
              }
         */

        public ETopic Topic { get { return ETopic.Ticker; } }

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
        /// Price change
        /// </summary>
        [JsonProperty("p")]
        public string PriceChange { get; set; }

        /// <summary>
        /// Price change percent
        /// </summary>
        [JsonProperty("P")]
        public string PriceChangePercent { get; set; }

        /// <summary>
        /// Weighted average price
        /// </summary>
        [JsonProperty("w")]
        public string WeightedAveragePrice { get; set; }

        /// <summary>
        /// Previous day's close price
        /// </summary>
        [JsonProperty("x")]
        public string PreviousDaysClosePrice { get; set; }

        /// <summary>
        /// Current day's close price
        /// </summary>
        [JsonProperty("c")]
        public string CurrentDaysClosePrice { get; set; }

        /// <summary>
        ///  Close trade's quantity
        /// </summary>
        [JsonProperty("Q")]
        public string CloseTradesQuantity { get; set; }

        /// <summary>
        /// Best bid price
        /// </summary>
        [JsonProperty("b")]
        public string BestBidPrice { get; set; }

        /// <summary>
        /// Best bid quantity
        /// </summary>
        [JsonProperty("B")]
        public string BestBidQuantity { get; set; }

        /// <summary>
        /// Best ask price
        /// </summary>
        [JsonProperty("a")]
        public string BestAskPrice { get; set; }

        /// <summary>
        /// Best ask quantity
        /// </summary>
        [JsonProperty("A")]
        public string BestAskQuantity { get; set; }

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

        /// <summary>
        /// Statistics open time
        /// </summary>
        [JsonProperty("O")]
        public long StatisticsOpenTime { get; set; }

        /// <summary>
        /// Statistics close time
        /// </summary>
        [JsonProperty("C")]
        public long StatisticsCloseTime { get; set; }

        /// <summary>
        /// First trade ID
        /// </summary>
        [JsonProperty("F")]
        public string FirstTradeID { get; set; }

        /// <summary>
        /// Last trade Id
        /// </summary>
        [JsonProperty("L")]
        public string LasttradeId { get; set; }

        /// <summary>
        /// Total number of trades
        /// </summary>
        [JsonProperty("n")]
        public long TotalNumberOfTrades { get; set; }
    }
}
