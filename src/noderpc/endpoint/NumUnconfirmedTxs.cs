using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    /*
        Get number of unconfirmed transactions. Query Parameters
        Parameter 	Type 	Default 	Required 	Description
        limit 	int 	30 	false 	Maximum number of entries (max: 100)
            
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

    public class ResultNumUnconfirmedTxs : IEndpointResponse
    {
        [JsonProperty("n_txs")]
        public string NTxs { get; set; }

        [JsonExtensionData, JsonProperty("txs")]
        public IDictionary<string, JToken> Txs { get; set; }
    }
}
