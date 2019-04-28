using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    /*
        {
          "jsonrpc": "2.0",
          "id": "",
          "result": {
            "block_height": "10779111",
            "consensus_params": {
              "block_size": {
                "max_bytes": "1048576",
                "max_gas": "-1"
              },
              "evidence": {
                "max_age": "100000"
              },
              "validator": {
                "pub_key_types": [
                  "ed25519"
                ]
              }
            }
          }
        }
    */

    public class ResultConsensusParams : IEndpointResponse
    {
        [JsonProperty("block_height")]
        public string BlockHeight { get; set; }

        [JsonProperty("consensus_params")]
        public ConsensusParams ConsensusParams { get; set; }
    }
}
