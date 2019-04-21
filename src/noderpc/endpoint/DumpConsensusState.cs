using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    public class DumpConsensusState
    {
        public static RpcRequest ConsensusStateRequest
        {
            get
            {
                return new RpcRequest
                {
                    Method = "dump_consensus_state",
                    JsonRpc = "2.0"
                };
            }
        }
    }
}
