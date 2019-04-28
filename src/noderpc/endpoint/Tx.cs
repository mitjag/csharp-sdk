using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    /*
        Tx allows you to query the transaction results. nil could mean the transaction is in the mempool, invalidated, or was not sent in the first place. Query Parameters
        Parameter 	Type 	Default 	Required 	Description
        hash 	[]byte 	nil 	true 	The transaction hash
        prove 	bool 	false 	false 	Include a proof of the transaction inclusion in the block

        Returns Parameters Returns a transaction matching the given transaction hash.

        // Result of querying for a tx
        type ResultTx struct {
            Hash     cmn.HexBytes          //hash of the transaction
            Height   int64                  //height of the block where this transaction was in
            Index    uint32                 //index of the transaction
            TxResult abci.ResponseDeliverTx //the `abci.Result` object
            Tx       types.Tx               //the transaction
            Proof    types.TxProof          //the `types.TxProof` object
        }

    */

    /*
        {
          "jsonrpc": "2.0",
          "id": "",
          "result": {
            "hash": "AB1B84C7C0B0B195941DCE9CFE1A54214B72D5DB54AD388D8B146A6B62911E8E",
            "height": "7560096",
            "index": 0,
            "tx_result": {
              "data": "eyJvcmRlcl9pZCI6IjgxM0U0OTM5RjE1NjdCMjE5NzA0RkZDMkFENERGNThCREUwMTA4NzktNDMifQ==",
              "log": "Msg 0: ",
              "tags": [
                {
                  "key": "YWN0aW9u",
                  "value": "b3JkZXJOZXc="
                }
              ]
            },
            "tx": "2wHwYl3uCmPObcBDChSBPkk58VZ7IZcE/8KtTfWL3gEIeRIrODEzRTQ5MzlGMTU2N0IyMTk3MDRGRkMyQUQ0REY1OEJERTAxMDg3OS00MxoNWkVCUkEtMTZEX0JOQiACKAEwwIQ9OJBOQAEScAom61rphyECE5vdld5ywirCorD4eFOxzKLorfnFikponHXTJjATRBoSQFmMOnTcCNgtl2aO01I6EFoq+3UsW+NNCftfMVjVXbL1RaJGYmPPgPAtEYTdUO/E2KY2omKQmmMuvt3qpCbAkrIY0uUYICo=",
            "proof": {
              "RootHash": "E9F1E1C63E64967EDEC2410657C6BED17CCB25BAE88CC6CE41499B8B60675F8D",
              "Data": "2wHwYl3uCmPObcBDChSBPkk58VZ7IZcE/8KtTfWL3gEIeRIrODEzRTQ5MzlGMTU2N0IyMTk3MDRGRkMyQUQ0REY1OEJERTAxMDg3OS00MxoNWkVCUkEtMTZEX0JOQiACKAEwwIQ9OJBOQAEScAom61rphyECE5vdld5ywirCorD4eFOxzKLorfnFikponHXTJjATRBoSQFmMOnTcCNgtl2aO01I6EFoq+3UsW+NNCftfMVjVXbL1RaJGYmPPgPAtEYTdUO/E2KY2omKQmmMuvt3qpCbAkrIY0uUYICo=",
              "Proof": {
                "total": "1",
                "index": "0",
                "leaf_hash": "6fHhxj5kln7ewkEGV8a+0XzLJbrojMbOQUmbi2BnX40=",
                "aunts": []
              }
            }
          }
        }
    */

    public class TxProofProof
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("leaf_hash")]
        public string Leaf_hash { get; set; }

        [JsonProperty("aunts")]
        public List<string> Aunts { get; set; }
    }

    public class TxProof
    {
        [JsonProperty("RootHash")]
        public string RootHash { get; set; }

        [JsonProperty("Data")]
        public string Data { get; set; }

        [JsonProperty("Proof")]
        public TxProofProof Proof { get; set; }
    }

    public class ResultTx : IEndpointResponse
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("index")]
        public long Index { get; set; }

        [JsonProperty("tx_result")]
        public Tx TxResult { get; set; }

        [JsonProperty("tx")]
        public string Tx { get; set; }

        [JsonProperty("proof")]
        public TxProof Proof { get; set; }
    }
}
