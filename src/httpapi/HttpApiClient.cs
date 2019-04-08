using binance.dex.sdk.broadcast;
using binance.dex.sdk.model;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace binance.dex.sdk.httpapi
{
    /// <summary>
    /// https://binance-chain.github.io/api-reference/dex-api/paths.html
    /// </summary>
    public class HttpApiClient : IHttpApi
    {
        public BinanceDexEnvironmentData BinanceDexEnvironmentData { get; }

        private readonly IRestClient restClient;

        public HttpApiClient(BinanceDexEnvironmentData binanceDexEnvironmentData)
        {
            restClient = new RestClient(binanceDexEnvironmentData.BaseUrl);
        }

        private T Execute<T>(RestRequest request) where T : new()
        {
            var response = restClient.Execute<T>(request);
            if (response.StatusCode != HttpStatusCode.OK || response.ErrorException != null)
            {
                string message = $"RestClient response error StatusCode: {(int)response.StatusCode} {response.StatusCode}";
                if (response.ErrorException != null)
                {
                    message += $" ErrorException: {response.ErrorException}";
                }
                IDeserializer deserializer = new JsonDeserializer();
                Error error = deserializer.Deserialize<Error>(response);
                throw new HttpApiException(message, response.ErrorException, error);
            }
            return response.Data;
        }

        public Times Time()
        {
            var request = new RestRequest("/api/v1/time", Method.GET);
            return Execute<Times>(request);
        }

        public List<TransactionMetadata> Broadcast(string body)
        {
            var request = new RestRequest("/api/v1/broadcast", Method.POST);
            request.AddParameter("POST", body, "text/plain; charset=utf-8", ParameterType.RequestBody);
            return Execute<List<TransactionMetadata>>(request);
        }

        /*
        /api/v1/node-info
        
        /api/v1/validators
        
        /api/v1/peers
        
        /api/v1/account/{address}
        address 	path 	The account address to query 	Yes 	string
        
        /api/v1/account/{address}/sequence
        address 	path 	The account address to query 	Yes 	string
        
        /api/v1/tx/{hash}
        hash 	path 	The transaction hash to query 	Yes 	string
        format 	query 	Response format (json or omit)

        /api/v1/tokens
        limit 	query 	default 500; max 1000. 	No 	integer
        offset 	query 	start with 0; default 0. 	No 	integer

        /api/v1/markets
        limit 	query 	default 500; max 1000. 	No 	integer
        offset 	query 	start with 0; default 0. 	No 	integer

        /api/v1/fees

        /api/v1/depth
        symbol 	query 	Market pair symbol, e.g. NNB-0AD_BNB 	Yes 	string
        limit 	query 	The limit of results. Allowed limits: [5, 10, 20, 50, 100, 500, 1000] 	No 	integer

        /api/v1/broadcast
        POST
        Description: Broadcasts a signed transaction. A single transaction must be sent hex-encoded with a content-type of text/plain
        sync 	query 	Synchronous broadcast (wait for DeliverTx)? 	No 	boolean
        body 	body 		Yes 	binary

        /api/v1/klines
        symbol 	query 	symbol 	Yes 	string
        interval 	query 	interval. Allowed value: [1m, 3m, 5m, 15m, 30m, 1h, 2h, 4h, 6h, 8h, 12h, 1d, 3d, 1w, 1M] 	Yes 	enum string
        limit 	query 	default 300; max 1000. 	No 	integer
        startTime 	query 	start time in Milliseconds 	No 	long
        endTime 	query 	end time in Milliseconds 	No 	long

        /api/v1/orders/closed
        address 	query 	the owner address 	Yes 	string
        end 	query 	end time in Milliseconds 	No 	long
        limit 	query 	default 500; max 1000. 	No 	integer
        offset 	query 	start with 0; default 0. 	No 	integer
        side 	query 	order side. 1 for buy and 2 for sell. 	No 	integer
        start 	query 	start time in Milliseconds 	No 	long
        status 	query 	order status list. Allowed value: [Ack, PartialFill, IocNoFill, FullyFill, Canceled, Expired, FailedBlocking, FailedMatching] 	No 	enum string
        symbol 	query 	symbol 	No 	string
        total 	query 	total number required, 0 for not required and 1 for required; default not required, return total=-1 in response 	No 	integer

        /api/v1/orders/open
        address 	query 	the owner address 	Yes 	string
        limit 	query 	default 500; max 1000. 	No 	integer
        offset 	query 	start with 0; default 0. 	No 	integer
        symbol 	query 	symbol 	No 	string
        total 	query 	total number required, 0 for not required and 1 for required; default not required, return total=-1 in response 	No 	integer

        /api/v1/orders/{id}
        id 	path 	order id 	Yes 	string

        /api/v1/ticker/24hr
        symbol 	query 	symbol 	No 	string

        /api/v1/trades
        address 	query 	the buyer/seller address 	No 	string
        buyerOrderId 	query 	buyer order id 	No 	string
        end 	query 	end time in Milliseconds 	No 	long
        height 	query 	block height 	No 	long
        limit 	query 	default 500; max 1000. 	No 	integer
        offset 	query 	start with 0; default 0. 	No 	integer
        quoteAsset 	query 	quote asset 	No 	string
        sellerOrderId 	query 	seller order id 	No 	string
        side 	query 	order side. 1 for buy and 2 for sell. 	No 	integer
        start 	query 	start time in Milliseconds 	No 	long
        symbol 	query 	symbol 	No 	string
        total 	query 	total number required, 0 for not required and 1 for required; default not required, return total=-1 in response 	No 	integer

        /api/v1/transactions
        address 	query 	address 	Yes 	string
        blockHeight 	query 	blockHeight 	No 	long
        endTime 	query 	endTime in Milliseconds 	No 	long
        limit 	query 	limit 	No 	integer
        offset 	query 	offset 	No 	integer
        side 	query 	transaction side. Allowed value: [ RECEIVE, SEND] 	No 	enum string
        startTime 	query 	start time in Milliseconds 	No 	long
        txAsset 	query 	txAsset 	No 	string
        txType 	query 	transaction type. Allowed value: [ NEW_ORDER,ISSUE_TOKEN,BURN_TOKEN,LIST_TOKEN,CANCEL_ORDER,FREEZE_TOKEN,UN_FREEZE_TOKEN,TRANSFER,PROPOSAL,VOTE,MINT,DEPOSIT] 	No 	enum string
        */
    }
}
