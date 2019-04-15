using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.message
{
    /// <summary>
    /// Json property order is alphabetic
    /// </summary>
    public class SignData
    {
        [JsonProperty("chain_id", Order = 2)]
        public string ChainId { get; set; }

        [JsonProperty("account_number", Order = 1)]
        public string AccountNumber { get; set; }

        [JsonProperty("sequence", Order = 6)]
        public string Sequence { get; set; }

        [JsonProperty("memo", Order = 4)]
        public string Memo { get; set; }

        [JsonProperty("msgs", Order = 5)]
        public ITransactionMessage[] Msgs { get; set; }

        [JsonProperty("source", Order = 7)]
        public string Source { get; set; }

        [JsonProperty("data", Order = 3)]
        public byte[] Data { get; set; }
    }
}
