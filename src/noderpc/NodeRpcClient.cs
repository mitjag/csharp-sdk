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

        private T Execute<T>(RestRequest request) where T : IEndpointResponse, new()
        {
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
            RestRequest request = new RestRequest("abci_info", Method.GET);
            return Execute<ResponseData>(request);
        }

        public ConsensusRoundStateData ConsensusState()
        {
            RestRequest request = new RestRequest("consensus_state", Method.GET);
            return Execute<ConsensusRoundStateData>(request);
        }

        public DumpRoundStateData DumpConsensusState()
        {
            RestRequest request = new RestRequest("dump_consensus_state", Method.GET);
            return Execute<DumpRoundStateData>(request);
        }

        public ResultNetInfo NetInfo()
        {
            RestRequest request = new RestRequest("net_info", Method.GET);
            return Execute<ResultNetInfo>(request);
        }

        public ResultGenesis Genesis()
        {
            RestRequest request = new RestRequest("genesis", Method.GET);
            return Execute<ResultGenesis>(request);
        }

        public ResultHealth Health()
        {
            RestRequest request = new RestRequest("health", Method.GET);
            return Execute<ResultHealth>(request);
        }

        public ResultUnconfirmedTxs NumUnconfirmedTxs()
        {
            RestRequest request = new RestRequest("num_unconfirmed_txs", Method.GET);
            return Execute<ResultUnconfirmedTxs>(request);
        }

        public ResultStatus Status()
        {
            RestRequest request = new RestRequest("status", Method.GET);
            return Execute<ResultStatus>(request);
        }

        public ResultBlock Block(long? height = null)
        {
            RestRequest request = new RestRequest("block", Method.GET);
            if (height.HasValue)
            {
                request.AddQueryParameter("height", height.Value.ToString());
            }
            return Execute<ResultBlock>(request);
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
