using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.message
{
    /// <summary>
    /// Json property order is alphabetic
    /// </summary>
    public class InputOutput : ITransactionMessage
    {
        [JsonProperty("address", Order = 1)]
        public string Address { get; set; }

        [JsonProperty("coins", Order = 2)]
        public List<Token> Coins { get; set; }
    }
}
