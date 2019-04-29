using binance.dex.sdk.noderpc.endpoint;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc
{
    /// <summary>
    /// RPC endpoints may be used to interact with a node directly over HTTP or websockets.
    /// Using RPC, you may perform low-level operations like executing
    /// ABCI queries, viewing network/consensus state or broadcasting a transaction.
    /// https://docs.binance.org/api-reference/node-rpc.html
    /// </summary>
    public interface INodeRpc
    {
        ResponseData AbciInfo();

        ConsensusRoundStateData ConsensusState();

        DumpRoundStateData DumpConsensusState();

        ResultNetInfo NetInfo();

        ResultGenesis Genesis();

        ResultHealth Health();

        ResultNumUnconfirmedTxs NumUnconfirmedTxs();

        ResultStatus Status();

        ResultAbciQuery AbciQuery(string path, string data = null, long height = 0, bool prove = false);

        ResultAbciQuery AbciQueryTokenList(int offset = 0, int limit = 10);

        ResultBlock Block(long? height = null);

        ResultBlock BlockByHash(string hash);

        ResultBlockResults BlockResults(long? height = null);

        ResultBlockchainInfo Blockchain(long minHeight, long maxHeight);

        ResultCommit Commit(long? height = null);

        ResultConsensusParams ConsensusParams(long? height = null);

        ResultTx Tx(string hash, bool prove = false);

        ResultTxSearch TxSearch(string query, bool prove = false, int page = 1, int perPage = 30);

        ResultUnconfirmedTxs UnconfirmedTxs(int? limit = null);

        ResultValidators Validators(long? height = null);

        ResultBroadcastTx BroadcastTxAsync(string tx);

        ResultBroadcastTxCommit BroadcastTxCommit(string tx);

        ResultBroadcastTx BroadcastTxSync(string tx);
    }
}
