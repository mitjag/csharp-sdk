using RestSharp;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.httpapi
{
    public class HttpApiClient : IHttpApi
    {
        public BinanceDexEnvironmentData BinanceDexEnvironmentData { get; }

        private readonly RestClient restClient;

        public HttpApiClient(BinanceDexEnvironmentData binanceDexEnvironmentData)
        {
            restClient = new RestClient(binanceDexEnvironmentData.BaseUrl);
        }

        public void Time()
        {
            var request = new RestRequest("/api/v1/time", Method.GET);
            var response = restClient.Execute(request);
        }
    }
}
