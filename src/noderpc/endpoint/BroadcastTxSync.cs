using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    /*
        BroadcastTxSync

        The transaction will be broadcasted and returns with the response from CheckTx. Transaction Parameters | Parameter | Type | Default | Required | Description | |-----------|------|---------|----------|-----------------| | tx | Tx | nil | true | The transaction info bytes in hex|

        Return Parameters CheckTx results

        type ResultBroadcastTx struct {
            Code uint32       
            Data cmn.HexBytes 
            Log  string       
            Hash cmn.HexBytes 
        }
    */

    /*
        {
          "jsonrpc": "2.0",
          "id": "",
          "result": {
            "code": 0,
            "data": "7B226F726465725F6964223A22383133453439333946313536374232313937303446464332414434444635384244453031303837392D3438227D",
            "log": "Msg 0: ",
            "hash": "920EA6B3EE38AC9B700AB436DABCA8F3D97F06EA63CBCACA7AD22B2E5CA1DF75"
          }
        }
    */

    public class ResultBroadcastTx : IEndpointResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("log")]
        public string Log { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }
}
