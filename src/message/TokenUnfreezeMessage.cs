using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.message
{
    /// <summary>
    /// Json property order is alphabetic
    /// </summary>
    public class TokenUnfreezeMessage : ITransactionMessage
    {
        [JsonProperty("from", Order = 2)]
        public string From { get; set; }

        [JsonProperty("symbol", Order = 3)]
        public string Symbol { get; set; }

        [JsonProperty("amount", Order = 1)]
        public long Amount { get; set; }
    }
}
