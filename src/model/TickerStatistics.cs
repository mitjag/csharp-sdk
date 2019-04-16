using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class TickerStatistics
    {
        /*
            {
                "symbol": "GLC-0C7_BNB",
                "priceChange": "0.00000000",
                "priceChangePercent": "0.0000",
                "prevClosePrice": "0.81000000",
                "lastPrice": "0.81000000",
                "lastQuantity": "1.00000000",
                "openPrice": "0.81000000",
                "highPrice": "0.81000000",
                "lowPrice": "0.81000000",
                "openTime": 1555301538537,
                "closeTime": 1555387938537,
                "firstId": "3033814-0",
                "lastId": "3033814-0",
                "bidPrice": "0",
                "bidQuantity": "0",
                "askPrice": "0",
                "askQuantity": "0",
                "weightedAvgPrice": "0.81000000",
                "volume": "0",
                "quoteVolume": "0",
                "count": 0
            }
        */

        /// <summary>
        /// symbol  string
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// priceChange     string
        /// </summary>
        [JsonProperty("priceChange")]
        public string PriceChange { get; set; }

        /// <summary>
        /// priceChangePercent  string
        /// </summary>
        [JsonProperty("priceChangePercent")]
        public string PriceChangePercent { get; set; }

        /// <summary>
        /// prevClosePrice  string
        /// </summary>
        [JsonProperty("prevClosePrice")]
        public string PrevClosePrice { get; set; }

        /// <summary>
        /// lastPrice   string
        /// </summary>
        [JsonProperty("lastPrice")]
        public string LastPrice { get; set; }

        /// <summary>
        /// lastQuantity    string
        /// </summary>
        [JsonProperty("lastQuantity")]
        public string LastQuantity { get; set; }

        /// <summary>
        /// openPrice   string
        /// </summary>
        [JsonProperty("openPrice")]
        public string OpenPrice { get; set; }

        /// <summary>
        /// highPrice   string
        /// </summary>
        [JsonProperty("highPrice")]
        public string HighPrice { get; set; }

        /// <summary>
        /// lowPrice    string
        /// </summary>
        [JsonProperty("lowPrice")]
        public string LowPrice { get; set; }

        /// <summary>
        /// openTime    long
        /// </summary>
        [JsonProperty("openTime")]
        public long OpenTime { get; set; }

        /// <summary>
        /// closeTime   long time of closing
        /// </summary>
        [JsonProperty("closeTime")]
        public long CloseTime { get; set; }

        /// <summary>
        /// firstId     string
        /// </summary>
        [JsonProperty("firstId")]
        public string FirstId { get; set; }

        /// <summary>
        /// lastId  string
        /// </summary>
        [JsonProperty("lastId")]
        public string LastId { get; set; }

        /// <summary>
        /// bidPrice    string bid price
        /// </summary>
        [JsonProperty("bidPrice")]
        public string BidPrice { get; set; }

        /// <summary>
        /// bidQuantity     string bid quantity
        /// </summary>
        [JsonProperty("bidQuantity")]
        public string BidQuantity { get; set; }

        /// <summary>
        /// askPrice string ask price
        /// </summary>
        [JsonProperty("askPrice")]
        public string AskPrice { get; set; }

        /// <summary>
        /// askQuantity     string ask quantity
        /// </summary>
        [JsonProperty("askQuantity")]
        public string AskQuantity { get; set; }

        /// <summary>
        /// weightedAvgPrice    string
        /// </summary>
        [JsonProperty("weightedAvgPrice")]
        public string WeightedAvgPrice { get; set; }

        /// <summary>
        /// volume  string
        /// </summary>
        [JsonProperty("volume")]
        public string Volume { get; set; }

        /// <summary>
        /// quoteVolume     string
        /// </summary>
        [JsonProperty("quoteVolume")]
        public string QuoteVolume { get; set; }

        /// <summary>
        /// count long total count
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; set; }
    }
}
