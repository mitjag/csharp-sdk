using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    public class BlockRequestArguments
    {
        [JsonProperty("height")]
        public long Height { get; set; }
    }

    public class BlockRequest
    {
        public static RpcRequest Request(BlockRequestArguments arguments)
        {
            return new RpcRequest
            {
                Method = "block",
                JsonRpc = "2.0",
                //Params = new List<string> { JsonConvert.SerializeObject(arguments) }
                Params = new List<string> { arguments.Height.ToString() }
            };
        }
    }

    /*
        Get block at a given height. If no height is provided, it will fetch the latest block.

        Query Parameters
        Parameter 	Type 	Default 	Required 	Description
        height 	int64 	false 	false 	height of blockchain
        Return Type: 				

        type ResultBlock struct {
            BlockMeta *types.BlockMeta 
            Block     *types.Block     
        }
        // BlockMeta contains meta information about a block - namely, it's ID and Header.
        type BlockMeta struct {
            BlockID BlockID  
            Header  Header     
        }
        // Block defines the atomic unit of a Tendermint blockchain.
        type Block struct {
            mtx        sync.Mutex
            Header     `json:"header"`
            Data       `json:"data"`
            Evidence   EvidenceData 
            LastCommit *Commit      
        }
    */

    public class ResultBlock : IEndpointResponse
    {
    }
}
