using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket.stream
{
    public class Blockheight : IStreamData
    {
        [JsonProperty("h")]
        public long BlockHeight { get; set; }
    }
}
