using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket.stream
{
    public class CoinAmount
    {
        /*
            {
                "a":"BNB",                                                           // Asset
                "A":"100.00000000"                                                   // Amount
            }
        */

        /// <summary>
        /// Asset
        /// </summary>
        [JsonProperty("a")]
        public string Asset { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("A")]
        public string Amount { get; set; }
    }

    public class Transfer
    {
        /*
            {
                "o":"bnb1xngdalruw8g23eqvpx9klmtttwvnlk2x4lfccu",                      // To addr
                "c":[{                                                                 // Coins
                  "a":"BNB",                                                           // Asset
                  "A":"100.00000000"                                                   // Amount
            }
        */

        /// <summary>
        /// To addr
        /// </summary>
        [JsonProperty("o")]
        public string ToAddr { get; set; }

        /// <summary>
        /// Coins
        /// </summary>
        [JsonProperty("c")]
        public List<CoinAmount> Amount { get; set; }
    }

    public class TransfersData : IStreamData
    {
        /*
            {
                "e":"outboundTransferInfo",                                                // Event type
                "E":12893,                                                                 // Event height
                "H":"0434786487A1F4AE35D49FAE3C6F012A2AAF8DD59EC860DC7E77123B761DD91B",    // Transaction hash
                "f":"bnb1z220ps26qlwfgz5dew9hdxe8m5malre3qy6zr9",                          // From addr
                "t":
                  [{
                    "o":"bnb1xngdalruw8g23eqvpx9klmtttwvnlk2x4lfccu",                      // To addr
                    "c":[{                                                                 // Coins
                      "a":"BNB",                                                           // Asset
                      "A":"100.00000000"                                                   // Amount
                      }]
                  }]
          }
         */

        public ETopic Topic { get { return ETopic.Transfers; } }

        /// <summary>
        /// Event type
        /// </summary>
        [JsonProperty("e")]
        public string EventType { get; set; }

        /// <summary>
        /// Event height
        /// </summary>
        [JsonProperty("E")]
        public string EventHeight { get; set; }

        /// <summary>
        /// Transaction hash
        /// </summary>
        [JsonProperty("H")]
        public string TransactionHash { get; set; }

        /// <summary>
        /// From addr
        /// </summary>
        [JsonProperty("f")]
        public string FromAaddr { get; set; }

        [JsonProperty("t")]
        public List<Transfer> Transfers { get; set; }
    }
}
