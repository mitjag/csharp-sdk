using binance.dex.sdk.noderpc.endpoint;
using binance.dex.sdk.util;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace binance.dex.sdk.noderpc
{
    /// <summary>
    /// Node RCP client using protocol:
    /// JSONRPC over HTTP
    /// </summary>
    public class NodeRpcClient
    {
        public string Endpoint { get; }

        private readonly IRestClient restClient;

        public NodeRpcClient(string endpoint)
        {
            Endpoint = endpoint;
            restClient = new RestClient(endpoint).UseSerializer(() => new JsonNetSerializer());
        }

        private T Execute<T>(RpcRequest rpcRequest) where T : IEndpointResponse, new()
        {
            RestRequest request = new RestRequest("", Method.POST);
            request.AddJsonBody(rpcRequest);
            var response = restClient.Execute<RpcResponse<T>>(request);
            if (response.StatusCode != HttpStatusCode.OK || response.ErrorException != null)
            {
                string message = $"RestClient response error StatusCode: {(int)response.StatusCode} {response.StatusCode}";
                if (response.ErrorException != null)
                {
                    message += $" ErrorException: {response.ErrorException}";
                }
                throw new NodeRpcException(message, response.ErrorException, response.Data?.Error);
            }
            if (response.Data.Error != null)
            {
                throw new NodeRpcException("Error received code: " + response.Data.Error.Code + " message: " + response.Data.Error.Message + " data: " + response.Data.Error.Data, response.Data.Error);
            }
            return response.Data.Result;
        }

        /*
            Available endpoints:
                //data-seed-pre-0-s1.binance.org/abci_info
                //data-seed-pre-0-s1.binance.org/consensus_state
                //data-seed-pre-0-s1.binance.org/dump_consensus_state
                //data-seed-pre-0-s1.binance.org/genesis
                //data-seed-pre-0-s1.binance.org/health
                //data-seed-pre-0-s1.binance.org/net_info
                //data-seed-pre-0-s1.binance.org/num_unconfirmed_txs
                //data-seed-pre-0-s1.binance.org/status
         */

        public ResponseData AbciInfo()
        {
            return Execute<ResponseData>(AbciInfoRequest.Request());
        }

        public ConsensusRoundStateData ConsensusState()
        {
            return Execute<ConsensusRoundStateData>(ConsensusStateRequest.Request());
        }

        public DumpRoundStateData DumpConsensusState()
        {
            return Execute<DumpRoundStateData>(DumpConsensusStateRequest.Request());
        }

        public ResultNetInfo NetInfo()
        {
            return Execute<ResultNetInfo>(NetInfoRequest.Request());
        }

        public ResultGenesis Genesis()
        {
            return Execute<ResultGenesis>(GenesisRequest.Request());
        }

        public ResultHealth Health()
        {
            return Execute<ResultHealth>(HealthRequest.Request());
        }

        public ResultUnconfirmedTxs NumUnconfirmedTxs()
        {
            return Execute<ResultUnconfirmedTxs>(NumUnconfirmedTxsRequest.Request());
        }

        public ResultStatus Status()
        {
            return Execute<ResultStatus>(StatusRequest.Request());
        }

        public ResultBlock Block(long height)
        {
            return Execute<ResultBlock>(BlockRequest.Request(new BlockRequestArguments { Height = height }));
        }

        /*
            Endpoints that require arguments:
                //data-seed-pre-0-s1.binance.org/abci_query?path=_&data=_&height=_&prove=_
                //data-seed-pre-0-s1.binance.org/block?height=_
                //data-seed-pre-0-s1.binance.org/block_by_hash?hash=_
                //data-seed-pre-0-s1.binance.org/block_results?height=_
                //data-seed-pre-0-s1.binance.org/blockchain?minHeight=_&maxHeight=_
                //data-seed-pre-0-s1.binance.org/broadcast_tx_async?tx=_
                //data-seed-pre-0-s1.binance.org/broadcast_tx_commit?tx=_
                //data-seed-pre-0-s1.binance.org/broadcast_tx_sync?tx=_
                //data-seed-pre-0-s1.binance.org/commit?height=_
                //data-seed-pre-0-s1.binance.org/consensus_params?height=_
                //data-seed-pre-0-s1.binance.org/subscribe?query=_
                //data-seed-pre-0-s1.binance.org/tx?hash=_&prove=_
                //data-seed-pre-0-s1.binance.org/tx_search?query=_&prove=_&page=_&per_page=_
                //data-seed-pre-0-s1.binance.org/unconfirmed_txs?limit=_
                //data-seed-pre-0-s1.binance.org/unsubscribe?query=_
                //data-seed-pre-0-s1.binance.org/unsubscribe_all?
                //data-seed-pre-0-s1.binance.org/validators?height=_
         */
    }
}
