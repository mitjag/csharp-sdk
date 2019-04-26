using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    /*
     * Get some info about the application. Return Type:
     * 
        type ResponseInfo struct {
            Data                 string
            Version              string
            AppVersion           uint64
            LastBlockHeight      int64
            LastBlockAppHash     []byte
        }     
    */

    /*
        {
          "jsonrpc": "2.0",
          "id": "",
          "result": {
            "response": {
              "data": "BNBChain",
              "last_block_height": "9611317",
              "last_block_app_hash": "/drwJ+9iLMHGHN8ott4Niux5gZeuCpayZ5HtxBsoScM="
            }
          }
        }
    */

    public class ResponseInfo
    {
        [JsonProperty("data")]
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
