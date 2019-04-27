using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    /*
        Get block headers for minHeight <= height <= maxHeight. Block headers are returned in descending order (highest first). Query Parameters
        Parameter 	Type 	Default 	Required 	Description
        minHeight 	int64 	false 	true 	height of blockchain
        maxHeight 	int64 	false 	true 	height of blockchain

        Return Type: List of blocks

        type ResultBlockchainInfo struct {
            LastHeight int64
            BlockMetas []*types.BlockMeta
        }
    */

    public class ResultBlockchainInfo : IEndpointResponse
    {
        [JsonProperty("last_height")]
        public string LastHeight { get; set; }

        [JsonProperty("block_metas")]
        public List<BlockMeta> BlockMetas { get; set; }
    }
}
