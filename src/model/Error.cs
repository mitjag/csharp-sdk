using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class Error
    {
        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
