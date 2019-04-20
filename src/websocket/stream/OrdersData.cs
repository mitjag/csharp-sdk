using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket.stream
{
    /// <summary>
    /// 
    /// </summary>
    public class Order
    {
        /*
            {
                "e": "executionReport",        // Event type
                "E": 1499405658658,            // Event height
                "s": "ETH_BTC",                // Symbol
                "S": 1,                        // Side, 1 for Buy; 2 for Sell
                "o": 2,                        // Order type, 2 for LIMIT (only)
                "f": 1,                        // Time in force,  1 for Good Till Expire (GTE); 3 for Immediate Or Cancel (IOC)
                "q": "1.00000000",             // Order quantity
                "p": "0.10264410",             // Order price
                "x": "NEW",                    // Current execution type
                "X": "Ack",                    // Current order status, possible values Ack, Canceled, Expired, IocNoFill, PartialFill, FullyFill, FailedBlocking, FailedMatching, Unknown
                "i": "91D9...7E18-2317",       // Order ID
                "l": "0.00000000",             // Last executed quantity
                "z": "0.00000000",             // Cumulative filled quantity
                "L": "0.00000000",             // Last executed price
                "n": "10000BNB",               // Commission amount for all user trades within a given block. Fees will be displayed with each order but will be charged once.
                                                // Fee can be composed of a single symbol, ex: "10000BNB"
                                                // or multiple symbols if the available "BNB" balance is not enough to cover the whole fees, ex: "1.00000000BNB;0.00001000BTC;0.00050000ETH"
                "T": 1499405658657,            // Transaction time
                "t": "TRD1",                   // Trade ID
                "O": 1499405658657,            // Order creation time
            }
        */

        /// <summary>
        /// Event type
        /// </summary>
        [JsonProperty("e")]
        public string EventType { get; set; }

        /// <summary>
        /// Event height
        /// </summary>
        [JsonProperty("E")]
        public long EventHeight { get; set; }

        /// <summary>
        /// Symbol
        /// </summary>
        [JsonProperty("s")]
        public string Symbol { get; set; }

        /// <summary>
        /// Side, 1 for Buy; 2 for Sell
        /// </summary>
        [JsonProperty("S")]
        public int Side { get; set; }

        /// <summary>
        /// Order type, 2 for LIMIT (only)
        /// </summary>
        [JsonProperty("o")]
        public int OrderType { get; set; }

        /// <summary>
        /// Time in force,  1 for Good Till Expire (GTE); 3 for Immediate Or Cancel (IOC)
        /// </summary>
        [JsonProperty("f")]
        public int TimeInForce { get; set; }


        /// <summary>
        /// Order quantity
        /// </summary>
        [JsonProperty("q")]
        public string OrderQuantity { get; set; }

        /// <summary>
        /// Order price
        /// </summary>
        [JsonProperty("p")]
        public string OrderPrice { get; set; }

        /// <summary>
        /// Current execution type
        /// </summary>
        [JsonProperty("x")]
        public string CurrentExecutionType { get; set; }

        /// <summary>
        /// Current order status, possible values Ack, Canceled, Expired, IocNoFill, PartialFill, FullyFill, FailedBlocking, FailedMatching, Unknown
        /// </summary>
        [JsonProperty("X")]
        public string CurrentOrderStatus { get; set; }

        /// <summary>
        /// Order ID
        /// </summary>
        [JsonProperty("i")]
        public string OrderID { get; set; }

        /// <summary>
        /// Last executed quantity
        /// </summary>
        [JsonProperty("l")]
        public string LastExecutedQuantity { get; set; }

        /// <summary>
        /// Cumulative filled quantity
        /// </summary>
        [JsonProperty("z")]
        public string CumulativeFilledQuantity { get; set; }

        /// <summary>
        /// Last executed price
        /// </summary>
        [JsonProperty("L")]
        public string LastExecutedPrice { get; set; }

        /// <summary>
        /// Commission amount for all user trades within a given block. Fees will be displayed with each order but will be charged once.
        /// Fee can be composed of a single symbol, ex: "10000BNB"
        /// or multiple symbols if the available "BNB" balance is not enough to cover the whole fees, ex: "1.00000000BNB;0.00001000BTC;0.00050000ETH"
        /// </summary>
        [JsonProperty("n")]
        public string CommissionAmount { get; set; }


        /// <summary>
        /// Transaction time
        /// </summary>
        [JsonProperty("T")]
        public long TransactionTime { get; set; }

        /// <summary>
        /// Trade ID
        /// </summary>
        [JsonProperty("t")]
        public string TradeID { get; set; }

        /// <summary>
        /// Order creation time
        /// </summary>
        [JsonProperty("O")]
        public long OrderCreationTime { get; set; }
    }

    public class OrdersData : IStreamData
    {
        /*
         [{
        "e": "executionReport",        // Event type
        "E": 1499405658658,            // Event height
        "s": "ETH_BTC",                // Symbol
        "S": 1,                        // Side, 1 for Buy; 2 for Sell
        "o": 2,                        // Order type, 2 for LIMIT (only)
        "f": 1,                        // Time in force,  1 for Good Till Expire (GTE); 3 for Immediate Or Cancel (IOC)
        "q": "1.00000000",             // Order quantity
        "p": "0.10264410",             // Order price
        "x": "NEW",                    // Current execution type
        "X": "Ack",                    // Current order status, possible values Ack, Canceled, Expired, IocNoFill, PartialFill, FullyFill, FailedBlocking, FailedMatching, Unknown
        "i": "91D9...7E18-2317",       // Order ID
        "l": "0.00000000",             // Last executed quantity
        "z": "0.00000000",             // Cumulative filled quantity
        "L": "0.00000000",             // Last executed price
        "n": "10000BNB",               // Commission amount for all user trades within a given block. Fees will be displayed with each order but will be charged once.
                                       // Fee can be composed of a single symbol, ex: "10000BNB"
                                       // or multiple symbols if the available "BNB" balance is not enough to cover the whole fees, ex: "1.00000000BNB;0.00001000BTC;0.00050000ETH"
        "T": 1499405658657,            // Transaction time
        "t": "TRD1",                   // Trade ID
        "O": 1499405658657,            // Order creation time
    },
    {
        "e": "executionReport",        // Event type
        "E": 1499405658658,            // Event height
        "s": "ETH_BNB",                // Symbol
        "S": "BUY",                    // Side
        "o": "LIMIT",                  // Order type
        "f": "GTE",                    // Time in force
        "q": "1.00000000",             // Order quantity
        "p": "0.10264410",             // Order price
        "x": "NEW",                    // Current execution type
        "X": "Ack",                    // Current order status
        "i": 4293154,                  // Order ID
        "l": "0.00000000",             // Last executed quantity
        "z": "0.00000000",             // Cumulative filled quantity
        "L": "0.00000000",             // Last executed price
        "n": "10000BNB",               // Commission amount for all user trades within a given block. Fees will be displayed with each order but will be charged once.
                                        // Fee can be composed of a single symbol, ex: "10000BNB"
                                        // or multiple symbols if the available "BNB" balance is not enough to cover the whole fees, ex: "1.00000000BNB;0.00001000BTC;0.00050000ETH"
        "T": 1499405658657,            // Transaction time
        "t": "TRD2",                   // Trade ID
        "O": 1499405658657,            // Order creation time
      }]
         */
        
        public ETopic Topic { get { return ETopic.Orders; } }

        public List<Order> Orders { get; set; }
    }
}
