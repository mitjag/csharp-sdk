using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.message
{
    /// <summary>
    /// Json property order is alphabetic
    /// </summary>
    public class CancelOrderMessage : ITransactionMessage
    {
        [JsonProperty("sender", Order = 2)]
        public string Sender { get; set; }

        [JsonProperty("symbol", Order = 3)]
        public string Symbol { get; set; }

        [JsonProperty("refid", Order = 1)]
        public string RefId { get; set; }
    }
}
