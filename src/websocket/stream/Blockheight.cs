using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket.stream
{
    public class Blockheight : IStreamData
    {
        public ETopic Topic { get { return ETopic.Blockheight;  } }

        [JsonProperty("h")]
        public long BlockHeight { get; set; }
    }
}
