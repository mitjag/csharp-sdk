using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            "n_txs": "0",
            "txs": []
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
