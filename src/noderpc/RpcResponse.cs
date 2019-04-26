using binance.dex.sdk.noderpc.endpoint;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc
{
    public class Error
    {
        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class NoResult : IEndpointResponse
    {
    }

    public class RpcResponse <T> where T : IEndpointResponse, new()
    {
        /*
            {
                "jsonrpc": "2.0", 
                "id": "", 
                "result": {
                    "response": {
                        "data": "BNBChain", 
                        "last_block_height": "7579978", 
                        "last_block_app_hash": "92HKpxrNKqYkzSRj49FI+PjzVx7oirnYrwhMzG0CRDg="
                }
            }
}
        */

        [JsonProperty("jsonrpc")]
        public string JsonRpc { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("result")]
        public T Result { get; set; }

        [JsonProperty("error")]
        public Error Error { get; set; }
    }
}
