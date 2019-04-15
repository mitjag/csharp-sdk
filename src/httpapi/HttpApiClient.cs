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

        public Infos NodeInfo()
        {
            var request = new RestRequest("/api/v1/node-info", Method.GET);
            return Execute<Infos>(request);
        }

        public ValidatorInfo Validators()
        {
            var request = new RestRequest("/api/v1/validators", Method.GET);
            return Execute<ValidatorInfo>(request);
        }

        public List<Peer> Peers()
        {
            var request = new RestRequest("/api/v1/peers", Method.GET);
            return Execute<List<Peer>>(request);
        }

        /// <summary>
        /// address 	path 	The account address to query 	Yes 	string
        /// </summary>
        /// <param name="address"></param>
        public Account Account(string address)
        {
            var request = new RestRequest($"/api/v1/account/{address}", Method.GET);
            return Execute<Account>(request);
        }

        /// <summary>
        /// address 	path 	The account address to query 	Yes 	string
        /// </summary>
        /// <param name="address"></param>
        public AccountSequence AccountSequence(string address)
        {
            var request = new RestRequest($"/api/v1/account/{address}/sequence", Method.GET);
            return Execute<AccountSequence>(request);
        }

        /// <summary>
        /// hash 	path 	The transaction hash to query 	Yes 	string
        /// format query   Response format(json or omit)
        /// </summary>
        /// <param name="hash"></param>
        public Transaction Tx(string hash, bool raw = true)
        {
            var request = new RestRequest($"/api/v1/tx/{hash}", Method.GET);
            if (!raw)
            {
                request.AddQueryParameter("format", "json");
            }
            return Execute<Transaction>(request);
        }

        /// <summary>
        /// limit 	query 	default 500; max 1000. 	No 	integer
        /// offset 	query 	start with 0; default 0. 	No 	integer
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        public List<Token> Tokens(int limit = 500, int offset = 0)
        {
            var request = new RestRequest("/api/v1/tokens", Method.GET);
            request.AddQueryParameter("limit", limit.ToString());
            request.AddQueryParameter("offset", offset.ToString());
            return Execute<List<Token>>(request);
        }

        /// <summary>
        /// limit 	query 	default 500; max 1000. 	No 	integer
        /// offset 	query 	start with 0; default 0. 	No 	integer
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        public List<Market> Markets(int limit = 500, int offset = 0)
        {
            var request = new RestRequest("/api/v1/markets", Method.GET);
            request.AddQueryParameter("limit", limit.ToString());
            request.AddQueryParameter("offset", offset.ToString());
            return Execute<List<Market>>(request);
        }

        public List<FeeData> Fees()
        {
            var request = new RestRequest("/api/v1/fees", Method.GET);
            return Execute<List<FeeData>>(request);
        }

        /// <summary>
        /// symbol 	query 	Market pair symbol, e.g. NNB-0AD_BNB 	Yes 	string
        /// limit 	query 	The limit of results. Allowed limits: [5, 10, 20, 50, 100, 500, 1000] 	No 	integer
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="limit"></param>
        public MarketDepth Depth(string symbol, int limit = 5)
        {
            var request = new RestRequest("/api/v1/depth", Method.GET);
            request.AddQueryParameter("symbol", symbol);
            request.AddQueryParameter("limit", limit.ToString());
            return Execute<MarketDepth>(request);
        }

        /// <summary>
        /// Description: Broadcasts a signed transaction. A single transaction must be sent hex-encoded with a content-type of text/plain
        /// sync 	query 	Synchronous broadcast (wait for DeliverTx)? 	No 	boolean
        /// body 	body 		Yes 	binary
        /// </summary>
        /// <param name="body"></param>
        public List<TransactionMetadata> Broadcast(string body, bool sync = true)
        {
            var request = new RestRequest("/api/v1/broadcast", Method.POST);
            request.RequestFormat = DataFormat.None;
            request.AddHeader("Content-Type", "text/plain; charset=utf-8");
            request.AddParameter("POST", body, "text/plain; charset=utf-8", ParameterType.RequestBody);
            return Execute<List<TransactionMetadata>>(request);
        }

        /// <summary>
        /// symbol 	query 	symbol 	Yes 	string
        /// interval 	query 	interval. Allowed value: [1m, 3m, 5m, 15m, 30m, 1h, 2h, 4h, 6h, 8h, 12h, 1d, 3d, 1w, 1M] 	Yes 	enum string
        /// limit 	query 	default 300; max 1000. 	No 	integer
        /// startTime 	query 	start time in Milliseconds 	No 	long
        /// endTime 	query 	end time in Milliseconds 	No 	long
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="interval"></param>
        /// <param name="limit"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        public List<List<object>> KLines(string symbol, string interval, int limit = 300, long? startTime = null, long? endTime = null)
        {
            var request = new RestRequest("/api/v1/klines", Method.GET);
            request.AddQueryParameter("symbol", symbol);
            request.AddQueryParameter("interval", interval);
            request.AddQueryParameter("limit", limit.ToString());
            if (startTime.HasValue)
            {
                request.AddQueryParameter("startTime", startTime.ToString());
            }
            if (endTime.HasValue)
            {
                request.AddQueryParameter("endTime", endTime.ToString());
            }
            return Execute<List<List<object>>>(request);
        }

        /// <summary>
        /// address 	query 	the owner address 	Yes 	string
        /// end query   end time in Milliseconds No  long
        /// limit   query 	default 500; max 1000. 	No integer
        /// offset query   start with 0; default 0. 	No integer
        /// side query   order side. 1 for buy and 2 for sell.No integer
        /// start query   start time in Milliseconds No  long
        /// status  query order status list. Allowed value: [Ack, PartialFill, IocNoFill, FullyFill, Canceled, Expired, FailedBlocking, FailedMatching]   No  enum string
        /// symbol  query symbol  No string
        /// total   query total number required, 0 for not required and 1 for required; default not required, return total=-1 in response No  integer
        /// </summary>
        /// <param name="address"></param>
        /// <param name="end"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="side"></param>
        /// <param name="start"></param>
        /// <param name="status"></param>
        /// <param name="symbol"></param>
        /// <param name="total"></param>
        public void Closed(string address, long end, int limit, int offset, int side, long start, string status, string symbol, int total)
        {
            var request = new RestRequest("/api/v1/orders/closed", Method.GET);
        }

        /// <summary>
        /// query 	the owner address 	Yes 	string
        /// limit query 	default 500; max 1000. 	No integer
        /// offset query   start with 0; default 0. 	No integer
        /// symbol query   symbol No  string
        /// total   query total number required, 0 for not required and 1 for required; default not required, return total=-1 in response No  integer
        /// </summary>
        /// <param name="addres"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="symbol"></param>
        /// <param name="total"></param>
        public void Open(string addres, int limit, int offset, string symbol, int total)
        {
            var request = new RestRequest("/api/v1/orders/open", Method.GET);
        }

        /// <summary>
        /// id 	path 	order id 	Yes 	string
        /// </summary>
        /// <param name="id"></param>
        public void Orders(string id)
        {
            var request = new RestRequest("/api/v1/orders/{id}", Method.GET);
        }

        /// <summary>
        /// symbol 	query 	symbol 	No 	string
        /// </summary>
        /// <param name="symbol"></param>
        public void Ticker24hr(string symbol)
        {
            var request = new RestRequest("/api/v1/ticker/24hr", Method.GET);
        }

        /// <summary>
        /// address 	query 	the buyer/seller address 	No 	string
        /// buyerOrderId query   buyer order id No  string
        /// end     query end time in Milliseconds No  long
        /// height  query block height No  long
        /// limit   query 	default 500; max 1000. 	No integer
        /// offset query   start with 0; default 0. 	No integer
        /// quoteAsset query   quote asset     No string
        /// sellerOrderId   query seller order id     No string
        /// side    query order side. 1 for buy and 2 for sell.No integer
        /// start query   start time in Milliseconds No  long
        /// symbol  query symbol  No string
        /// total   query total number required, 0 for not required and 1 for required; default not required, return total=-1 in response No  integer
        /// </summary>
        /// <param name="address"></param>
        /// <param name="buyerOrderId"></param>
        /// <param name="end"></param>
        /// <param name="height"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="quoteAsset"></param>
        /// <param name="seelerOrderId"></param>
        /// <param name="side"></param>
        /// <param name="start"></param>
        /// <param name="symbol"></param>
        /// <param name="total"></param>
        public void Trades(string address, string buyerOrderId, long end, long height, int limit, int offset, string quoteAsset, string seelerOrderId, int side, long start, string symbol, int total)
        {
            var request = new RestRequest("/api/v1/trades", Method.GET);
        }

        /// <summary>
        /// address 	query 	address 	Yes 	string
        /// blockHeight query   blockHeight No  long
        /// endTime     query endTime in Milliseconds No  long
        /// limit   query limit   No integer
        /// offset query   offset No  integer
        /// side    query transaction side.Allowed value: [RECEIVE, SEND] No enum string
        /// startTime   query start time in Milliseconds No  long
        /// txAsset     query txAsset     No string
        /// txType  query transaction type.Allowed value: [NEW_ORDER, ISSUE_TOKEN, BURN_TOKEN, LIST_TOKEN, CANCEL_ORDER, FREEZE_TOKEN, UN_FREEZE_TOKEN, TRANSFER, PROPOSAL, VOTE, MINT, DEPOSIT] No enum string
        /// </summary>
        /// <param name="address"></param>
        /// <param name="blockHeight"></param>
        /// <param name="endTime"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="side"></param>
        /// <param name="startTime"></param>
        /// <param name="txAsset"></param>
        /// <param name="txType"></param>
        public void Transactions(string address, long blockHeight, long endTime, int limit, int offset, string side, long startTime, string txAsset, string txType)
        {
            var request = new RestRequest("/api/v1/transactions", Method.GET);
        }
    }
}
