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
                IDeserializer deserializer = new JsonDeserializer();
                Error error = deserializer.Deserialize<Error>(response);
                throw new NodeRpcException(message, response.ErrorException, error);
            }
            return response.Data.Result;
        }

        public ResponseData AbciInfo()
        {
            return Execute<ResponseData>(AbciInfoRequest.Request);
        }

        public RoundStateData ConsensusState()
        {
            return Execute<RoundStateData>(ConsensusStateRequest.Request);
        }
    }
}
