using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket.stream
{
    public class Account
    {
        /*
            {
              "a": "LTC",               // Asset
              "f": "17366.18538083",    // Free amount
              "l": "0.00000000",        // Locked amount
              "r": "0.00000000"         // Frozen amount
            }
        */

        /// <summary>
        /// Asset
        /// </summary>
        [JsonProperty("a")]
        public string Asset { get; set; }

        /// <summary>
        /// Free amount
        /// </summary>
        [JsonProperty("f")]
        public string FreeAount { get; set; }

        /// <summary>
        /// Locked amount
        /// </summary>
        [JsonProperty("l")]
        public string LockedAmount { get; set; }

        /// <summary>
        /// Last executed price
        /// </summary>
        [JsonProperty("r")]
        public string FrozenAmount { get; set; }
    }

    public class AccountsData : IStreamData
    {
        /*
            [{
              "e": "outboundAccountInfo",   // Event type
              "E": 1499405658849,           // Event height
              "B": [                        // Balances array
                {
                  "a": "LTC",               // Asset
                  "f": "17366.18538083",    // Free amount
                  "l": "0.00000000",        // Locked amount
                  "r": "0.00000000"         // Frozen amount
                },
                {
                  "a": "BTC",
                  "f": "10537.85314051",
                  "l": "2.19464093",
                  "r": "0.00000000"
                },
                {
                  "a": "ETH",
                  "f": "17902.35190619",
                  "l": "0.00000000",
                  "r": "0.00000000"
                }
              ]
            }]
        */

        public ETopic Topic { get { return ETopic.Accounts; } }

        public List<Account> Accounts { get; set; }
    }
}
