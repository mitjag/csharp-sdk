using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.message
{
    //@JsonIgnoreProperties(ignoreUnknown = true)
    /// <summary>
    /// Json property order is alphabetic
    /// </summary>
    public class TokenUnfreezeMessage : ITransactionMessage
    {
        [JsonProperty("from", Order = 1)]
        public string From { get; set; }

        [JsonProperty("symbol", Order = 2)]
        public string symbol { get; set; }
    }
}
