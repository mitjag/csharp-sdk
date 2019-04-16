using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class Trade
    {
        /*
            {
              "tradeId": "8593935-0",
              "blockHeight": 8593935,
              "symbol": "BNB_USDT.B-B7C",
              "price": "18.94420000",
              "quantity": "46.39020000",
              "buyerOrderId": "F3EB0BB077E841D979D18564F53114F5CABE15DF-55194",
              "sellerOrderId": "B781E5DCDE55CFF666C9A3F630DFEAA4FA940CBA-2681",
              "buyerId": "tbnb1704shvrhapqaj7w3s4j02vg57h9tu9wlnd669p",
              "sellerId": "tbnb1k7q7thx72h8lvekf50mrphl25nafgr964e628r",
              "buyFee": "BNB:0.01855608;",
              "sellFee": "BNB:0.01855608;",
              "baseAsset": "BNB",
              "quoteAsset": "USDT.B-B7C",
              "time": 1555386390206
            }
        */

        /// <summary>
        /// tradeId     string trade ID
        /// </summary>
        [JsonProperty("tradeId")]
        public string TradeId { get; set; }

        /// <summary>
        /// blockHeight     long block height
        /// </summary>
        [JsonProperty("blockHeight")]
        public long BlockHeight { get; set; }

        /// <summary>
        /// symbol string asset symbol
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// price   string trade price
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// quantity    string trade quantity
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// buyerOrderId string order id for buyer
        /// </summary>
        [JsonProperty("buyerOrderId")]
        public string BuyerOrderId { get; set; }

        /// <summary>
        /// sellerOrderId   string seller order ID
        /// </summary>
        [JsonProperty("sellerOrderId")]
        public string SellerOrderId { get; set; }

        /// <summary>
        /// buyerId     string id of buyer
        /// </summary>
        [JsonProperty("buyerId")]
        public string BuyerId { get; set; }

        /// <summary>
        /// sellerId    string seller ID
        /// </summary>
        [JsonProperty("sellerId")]
        public string SellerId { get; set; }

        /// <summary>
        /// buyFee  string fees for buyer
        /// </summary>
        [JsonProperty("buyFee")]
        public string BuyFee { get; set; }

        /// <summary>
        /// sellFee     string fees for seller
        /// </summary>
        [JsonProperty("sellFee")]
        public string SellFee { get; set; }

        /// <summary>
        /// baseAsset string 	base asset
        /// </summary>
        [JsonProperty("baseAsset")]
        public string BaseAsset { get; set; }

        /// <summary>
        /// quoteAsset  string quote asset
        /// </summary>
        [JsonProperty("quoteAsset")]
        public string QuoteAsset { get; set; }

        /// <summary>
        /// time    long trade time
        /// </summary>
        [JsonProperty("time")]
        public long Time { get; set; }
    }
}
