using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class Order
    {
        /// <summary>
        /// cumulateQuantity string
        /// </summary>
        [JsonProperty("cumulateQuantity")]
        public string CumulateQuantity { get; set; }

        /// <summary>
        /// fee     string
        /// </summary>
        [JsonProperty("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// lastExecutedPrice   string price of last execution
        /// </summary>
        [JsonProperty("lastExecutedPrice")]
        public string LastExecutedPrice { get; set; }

        /// <summary>
        /// lastExecutedQuantity    string quantity of last execution
        /// </summary>
        [JsonProperty("lastExecutedQuantity")]
        public string LastExecutedQuantity { get; set; }

        /// <summary>
        /// orderCreateTime     dateTime time of order creation
        /// </summary>
        [JsonProperty("orderCreateTime")]
        public DateTime OrderCreateTime { get; set; }

        /// <summary>
        /// orderId     string order ID
        /// </summary>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// owner   string order issuer
        /// </summary>
        [JsonProperty("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// price   string order price
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// quantity string order quantity
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// side    integer 	1 for buy and 2 for sell
        /// </summary>
        [JsonProperty("side")]
        public string Side { get; set; }

        /// <summary>
        /// status  string enum [Ack, PartialFill, IocNoFill, FullyFill, Canceled, Expired, FailedBlocking, FailedMatching]
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// symbol string
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// tradeId string trade ID
        /// </summary>
        [JsonProperty("tradeId")]
        public string TradeId { get; set; }

        /// <summary>
        /// timeInForce     integer 	1 for Good Till Expire(GTE) order and 3 for Immediate Or Cancel(IOC)
        /// </summary>
        [JsonProperty("timeInForce")]
        public string TimeInForce { get; set; }

        /// <summary>
        /// transactionHash     string
        /// </summary>
        [JsonProperty("transactionHash")]
        public string TransactionHash { get; set; }

        /// <summary>
        /// transactionTime     dateTime time of transaction
        /// </summary>
        [JsonProperty("transactionTime")]
        public string TransactionTime { get; set; }

        /// <summary>
        /// type integer     only 2 is available for now, meaning limit order
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
