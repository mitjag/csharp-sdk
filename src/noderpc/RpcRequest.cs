using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc
{
    public class RpcRequest
    {
        /*
            {
                "method": "broadcast_tx_sync",
                "jsonrpc": "2.0",
                "params": [
                "abc"
                ],
                "id": "dontcare"
            }
        */

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("jsonrpc")]
        public string JsonRpc { get; set; }

        [JsonProperty("params")]
        public List<string> Params { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
