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
        private string Method { get; set; }

        [JsonProperty("jsonrpc")]
        private string jsonrpc { get; set; }

        [JsonProperty("params")]
        private List<string> Params { get; set; }

        [JsonProperty("id")]
        private string Id { get; set; }
    }
}
