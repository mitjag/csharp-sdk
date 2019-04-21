using binance.dex.sdk.noderpc.endpoint;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace binance.dex.sdk.noderpc
{
    public class NodeRpcClient
    {

        public string Endpoint { get; set; }

        private readonly IRestClient restClient;

        public NodeRpcClient(string endpoint)
        {
            Endpoint = endpoint;
            restClient = new RestClient(endpoint);
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
                //IDeserializer deserializer = new JsonDeserializer();
                //Error error = deserializer.Deserialize<Error>(response);
                throw new NodeRpcException(message, response.ErrorException);
            }
            return response.Data.Result;
        }

        public ResponseData AbcInfo()
        {
            return Execute<ResponseData>(AbciInfo.AbciInfoRequest);
        }
    }
}
