using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class Balance
    {
        /// <summary>
        /// symbol string (currency) asset symbol BNB
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// free string (fixed8) In decimal form, e.g. 0.00000000 	0.00000000
        /// </summary>
        [JsonProperty("free")]
        public string Free { get; set; }

        /// <summary>
        /// locked string (fixed8) In decimal form, e.g. 0.00000000 	0.00000000
        /// </summary>
        [JsonProperty("locked")]
        public string Locked { get; set; }

        /// <summary>
        /// frozen string (fixed8) In decimal form, e.g. 0.00000000 	0.00000000
        /// </summary>
        [JsonProperty("frozen")]
        public string Frozen { get; set; }
    }
}
