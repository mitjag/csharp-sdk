using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.message
{
    /// <summary>
    /// Json property order is alphabetic
    /// </summary>
    public class TransferMessage : ITransactionMessage
    {
        [JsonProperty("inputs", Order = 1)]
        public List<InputOutput> Inputs;

        [JsonProperty("outputs", Order = 2)]
        public List<InputOutput> Outputs;
    }
}
