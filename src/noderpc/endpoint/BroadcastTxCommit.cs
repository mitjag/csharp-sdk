using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    /*
        BroadcastTxCommit

        The transaction will be broadcasted and returns with the response from CheckTx and DeliverTx.

        This method will waitCONTRACT: only returns error if mempool.CheckTx() errs or if we timeout waiting for tx to commit.

        If CheckTx or DeliverTx fail, no error will be returned, but the returned result will contain a non-OK ABCI code. Transaction Parameters | Parameter | Type | Default | Required | Description | |-----------|------|---------|----------|-----------------| | tx | Tx | nil | true | The transaction info bytes in hex|

        Return Parameters CheckTx and DeliverTx results

        type ResultBroadcastTxCommit struct {
            CheckTx   abci.ResponseCheckTx   
            DeliverTx abci.ResponseDeliverTx 
            Hash      cmn.HexBytes           
            Height    int64                  
        }
    */

    /*
        {
          "jsonrpc": "2.0",
          "id": "",
          "result": {
            "check_tx": {
              "data": "eyJvcmRlcl9pZCI6IjgxM0U0OTM5RjE1NjdCMjE5NzA0RkZDMkFENERGNThCREUwMTA4NzktNDYifQ==",
              "log": "Msg 0: ",
              "tags": [
                {
                  "key": "YWN0aW9u",
                  "value": "b3JkZXJOZXc="
                }
              ]
            },
            "deliver_tx": {
              "data": "eyJvcmRlcl9pZCI6IjgxM0U0OTM5RjE1NjdCMjE5NzA0RkZDMkFENERGNThCREUwMTA4NzktNDYifQ==",
              "log": "Msg 0: ",
              "tags": [
                {
                  "key": "YWN0aW9u",
                  "value": "b3JkZXJOZXc="
                }
              ]
            },
            "hash": "008EA3C57B15E34B045F69DCEB2A5589B979B2B58BA282C15DF2AEA8B441AB6B",
            "height": "7734637"
          }
        }
    */

    public class ResultBroadcastTxCommit : IEndpointResponse
    {
        [JsonProperty("check_tx")]
        public ResultBroadcastTx CheckTx { get; set; }

        [JsonProperty("deliver_tx")]
        public ResultBroadcastTx DeliverTx { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }
    }
}
