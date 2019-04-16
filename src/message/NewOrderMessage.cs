using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.message
{
    /// <summary>
    /// Json property order is alphabetic
    /// </summary>
    public class NewOrderMessage : ITransactionMessage
    {
        [JsonProperty("id", Order = 1)]
        public string Id { get; set; }

        [JsonProperty("ordertype", Order = 2)]
        public long OrderType { get; set; }

        [JsonProperty("price", Order = 3)]
        public long Price { get; set; }

        [JsonProperty("quantity", Order = 4)]
        public long Quantity { get; set; }

        [JsonProperty("sender", Order = 5)]
        public string Sender { get; set; }

        [JsonProperty("side", Order = 6)]
        public long Side { get; set; }

        [JsonProperty("symbol", Order = 7)]
        public string Symbol { get; set; }

        [JsonProperty("timeinforce", Order = 8)]
        public long TimeInForce { get; set; }
    }
}
