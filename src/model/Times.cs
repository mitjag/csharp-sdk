using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class Times
    {
        [JsonProperty("ap_time")]
        public DateTime ApTime { get; set; }

        [JsonProperty("block_time")]
        public DateTime BlockTime { get; set; }
    }
}
