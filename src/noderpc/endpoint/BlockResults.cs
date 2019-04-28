using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{

    /*
        BlockResults gets ABCIResults at a given height. If no height is provided, it will fetch results for the latest block. Results are for the height of the block containing the txs. Thus response.results[5] is the results of executing getBlock(h).Txs[5]

        Query Parameters | Parameter | Type | Default | Required | Description | |-----------|--------|---------|----------|------------------------------------------------| | height | int64 | false | false | height of blockchain|

        Return Type:

        type ResultBlockResults struct {
            Height  int64                
            Results *state.ABCIResponses 
        }
    */

    public class TxTag
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Tx
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("log")]
        public string Log { get; set; }

        [JsonProperty("tags")]
        public List<TxTag> Tags { get; set; }
    }

    public class EndBlock
    {
        [JsonProperty("validator_updates")]
        public string ValidatorUpdates { get; set; }
    }

    public class BeginBlock
    {
    }

    public class Results
    {
        [JsonProperty("DeliverTx")]
        public List<Tx> DeliverTx { get; set; }
        
        [JsonProperty("EndBlock")]
        public EndBlock EndBlock { get; set; }
        
        [JsonProperty("BeginBlock")]
        public BeginBlock BeginBlock { get; set; }
    }

    public class ResultBlockResults : IEndpointResponse
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("results")]
        public Results Results { get; set; }
    }
}
