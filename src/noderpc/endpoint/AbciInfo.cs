using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    public class AbciInfo
    {
        public static RpcRequest AbciInfoRequest
        {
            get
            {
                return new RpcRequest
                {
                    Method = "abci_info",
                    JsonRpc = "2.0"
                };
            }
        }
    }

    /*
        type ResponseInfo struct {
            Data                 string
            Version              string
            AppVersion           uint64
            LastBlockHeight      int64
            LastBlockAppHash     []byte
        }     
     */
    public class ResponseInfo
    {
        [JsonProperty("data2")]
        public string Data { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        [JsonProperty("last_block_height")]
        public string LastBlockHeight { get; set; }

        [JsonProperty("last_block_app_hash")]
        public string LastBlockAppHash { get; set; }
    }

    public class ResponseData : IEndpointResponse
    {
        [JsonProperty("response")]
        public ResponseInfo Response { get; set; }
    }
}
