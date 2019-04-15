using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class MarketDepth
    {
        /// <summary>
        /// asks[string(fixed8)] Price and qty in decimal form, e.g. 1.00000000 	["1.00000000","800.00000000"]
        /// </summary>
        [JsonProperty("asks")]
        public List<List<string>> Asks { get; set; }

        /// <summary>
        /// bids[string(fixed8)] Price and qty in decimal form, e.g. 1.00000000 	["1.00000000","800.00000000"]
        /// </summary>
        [JsonProperty("bids")]
        public List<List<string>> Bids { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }
}
