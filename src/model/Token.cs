using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class Token
    {
        /// <summary>
        /// name string token name Binance Chain Native Token
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// symbol  string unique token trade symbol BTC-000
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// original_symbol string token symbol BTC
        /// </summary>
        [JsonProperty("original_symbol")]
        public string OriginalSymbol { get; set; }

        /// <summary>
        /// total_supply string (fixed8) total token supply in decimal form, e.g. 1.00000000 	0.00000000
        /// </summary>
        [JsonProperty("total_supply")]
        public string TotalSupply { get; set; }

        /// <summary>
        /// owner string (address) Address which issue the token
        /// </summary>
        [JsonProperty("owner")]
        public string Owner { get; set; }
    }
}
