using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket.stream
{
    public class Trade
    {
        /*
            {
                "e": "trade",       // Event type
                "E": 123456789,     // Event height
                "s": "BNB_BTC",     // Symbol
                "t": "12345",       // Trade ID
                "p": "0.001",       // Price
                "q": "100",         // Quantity
                "b": "88",          // Buyer order ID
                "a": "50",          // Seller order ID
                "T": 123456785,     // Trade time
                "sa": "bnb1me5u083m2spzt8pw8vunprnctc8syy64hegrcp", // SellerAddress
                "ba": "bnb1kdr00ydr8xj3ydcd3a8ej2xxn8lkuja7mdunr5" // BuyerAddress
            }
        */

        /// <summary>
        /// Event type
        /// </summary>
        [JsonProperty("e")]
        public string EventType { get; set; }

        /// <summary>
        /// Last executed price
        /// </summary>
        [JsonProperty("E")]
        public long EventHeight { get; set; }

        /// <summary>
        /// Symbol
        /// </summary>
        [JsonProperty("s")]
        public string Symbol { get; set; }

        /// <summary>
        /// Trade ID
        /// </summary>
        [JsonProperty("t")]
        public string TradeID { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [JsonProperty("p")]
        public string Price { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("q")]
        public string Quantity { get; set; }

        /// <summary>
        /// Buyer order ID
        /// </summary>
        [JsonProperty("b")]
        public string BuyerOrderID { get; set; }

        /// <summary>
        /// Seller order ID
        /// </summary>
        [JsonProperty("a")]
        public string SellerOrderID { get; set; }

        /// <summary>
        /// Trade time
        /// </summary>
        [JsonProperty("T")]
        public long TradeTime { get; set; }

        /// <summary>
        /// Seller address
        /// </summary>
        [JsonProperty("sa")]
        public string SellerAddress { get; set; }

        /// <summary>
        /// Buyer address
        /// </summary>
        [JsonProperty("ba")]
        public string BuyerAddress { get; set; }
    }

    public class TradesData : IStreamData
    {
        /*
            [{
                "e": "trade",       // Event type
                "E": 123456789,     // Event height
                "s": "BNB_BTC",     // Symbol
                "t": "12345",       // Trade ID
                "p": "0.001",       // Price
                "q": "100",         // Quantity
                "b": "88",          // Buyer order ID
                "a": "50",          // Seller order ID
                "T": 123456785,     // Trade time
                "sa": "bnb1me5u083m2spzt8pw8vunprnctc8syy64hegrcp", // SellerAddress
                "ba": "bnb1kdr00ydr8xj3ydcd3a8ej2xxn8lkuja7mdunr5" // BuyerAddress
            },
            {
                "e": "trade",       // Event type
                "E": 123456795,     // Event time
                "s": "BNB_BTC",     // Symbol
                "t": "12348",       // Trade ID
                "p": "0.001",       // Price
                "q": "100",         // Quantity
                "b": "88",          // Buyer order ID
                "a": "52",          // Seller order ID
                "T": 123456795,     // Trade time
                "sa": "bnb1me5u083m2spzt8pw8vunprnctc8syy64hegrcp", // SellerAddress
                "ba": "bnb1kdr00ydr8xj3ydcd3a8ej2xxn8lkuja7mdunr5" // BuyerAddress
            }]
         */

        public ETopic Topic { get { return ETopic.Trades; } }

        public List<Trade> Trades { get; set; }
    }
}
