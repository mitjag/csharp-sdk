using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    /*
        TxSearch allows you to query for multiple transactions results.You could search transaction by its index. It returns a list of transactions (maximum ?per_page entries) and the total count. Query Parameters
        Parameter 	Type 	Default 	Required 	Description
        query 	string 	"" 	true 	Query
        prove 	bool 	false 	false 	Include proofs of the transactions inclusion in the block
        page 	int 	1 	false 	Page number (1-based)
        per_page 	int 	30 	false 	Number of entries per page (max: 100)

        Returns Parameters
            proof: the types.TxProof object
            tx: []byte - the transaction
            tx_result: the abci.Result object
            index: int - index of the transaction
            height: int - height of the block where this transaction was in
            hash: []byte - hash of the transaction
    */

    public class ResultTxSearch : IEndpointResponse
    {
        [JsonProperty("txs")]
        public List<ResultTx> Txs { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
    }
}
