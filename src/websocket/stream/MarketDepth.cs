using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket.stream
{
    public class MarketDepth : IStreamData
    {
        /*
            {
                "lastUpdateId": 160,    // Last update ID
                "symbol": "BNB_BTC",    // symbol
                "bids": [               // Bids to be updated
                    [
                    "0.0024",           // Price level to be updated
                    "10"                // Quantity
                    ]
                ],
                "asks": [               // Asks to be updated
                    [
                    "0.0026",           // Price level to be updated
                    "100"               // Quantity
                    ]
                ]
            }
         */

        public ETopic Topic { get { return ETopic.MarketDepth; } }

        /// <summary>
        /// Last update ID
        /// </summary>
        [JsonProperty("lastUpdateId")]
        public long LastUpdateID { get; set; }

        /// <summary>
        /// symbol
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Bids to be updated
        /// </summary>
        [JsonProperty("e")]
        public List<List<string>> Bids { get; set; }

        /// <summary>
        /// Asks to be updated
        /// </summary>
        [JsonProperty("e")]
        public List<List<string>> Asks { get; set; }
    }
}
