using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.message
{
    /// <summary>
    /// Json property order is alphabetic
    /// </summary>
    public class Token
    {
        [JsonProperty("denom", Order = 2)]
        public string Denom { get; set; }

        [JsonProperty("amount", Order = 1)]
        public long Amount { get; set; }
    }
}
