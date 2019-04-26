using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    public class NumUnconfirmedTxsRequest
    {
        /// <summary>
        /// limit 	int 	30 	false 	Maximum number of entries (max: 100)
        /// </summary>
        /// <returns></returns>
        public static RpcRequest Request(int limit = 30)
        {
            return new RpcRequest
            {
                Method = "num_unconfirmed_txs",
                JsonRpc = "2.0"
            };
        }
    }

    /*
        Return Parameters

        // List of mempool txs
        type ResultUnconfirmedTxs struct {
            N   int        
            Txs []types.Tx 
        }
    */

    /*
        {
          "jsonrpc": "2.0",
          "id": "",
          "result": {
            "n_txs": "0",
            "txs": null
          }
        }
    */

    public class ResultUnconfirmedTxs : IEndpointResponse
    {
        [JsonProperty("n_txs")]
        public string NTxs { get; set; }

        [JsonExtensionData, JsonProperty("txs")]
        public IDictionary<string, JToken> Txs { get; set; }
    }
}
