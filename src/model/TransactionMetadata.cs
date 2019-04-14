using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class TransactionMetadata
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("log")]
        public string Log { get; set; }

        [JsonProperty("ok")]
        public bool Ok { get; set; }
    }
}
