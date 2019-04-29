using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    public enum EEndpointRequest
    {
        AbciInfo, ConsensusState, DumpConsesusState, NetInfo, Genesis, Health, NumUnconfirmedTxs, Status,
        AbciQuery, Block, BlockByHash, BlockResults, Blockchain, Commit, ConsensusParams, Tx, TxSearch, UnconfirmedTxs, Validators,
        BroadcastTxAsync, BroadcastTxCommit, BroadcastTxSync
    }
}
