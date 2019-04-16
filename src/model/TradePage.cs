using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class TradePage
    {
        /// <summary>
        /// trade[Trade]
        /// </summary>
        [JsonProperty("trade")]
        public List<Trade> Trades { get; set; }

        /// <summary>
        /// total long
        /// </summary>
        [JsonProperty("total")]
        public long Total { get; set; }
    }
}
