using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket.stream
{
    public class Payload<T> where T : IStreamData
    {
        [JsonProperty("stream")]
        public string Stream { get; set; }

        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
