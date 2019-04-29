using binance.dex.sdk.broadcast;
using binance.dex.sdk.model;
using binance.dex.sdk.util;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace binance.dex.sdk.httpapi
{
    /// <summary>
    /// https://binance-chain.github.io/api-reference/dex-api/paths.html
    /// </summary>
    public class HttpApiClient : IHttpApi, IHttpApiAsync
    {
        public BinanceDexEnvironmentData BinanceDexEnvironmentData { get; }

        private readonly IRestClient restClient;

        public HttpApiClient(BinanceDexEnvironmentData binanceDexEnvironmentData)
        {
            restClient = new RestClient(binanceDexEnvironmentData.BaseUrl).UseSerializer(() => new JsonNetSerializer());
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

        private RestRequest TimeRequest()
        {
            return new RestRequest("/api/v1/time", Method.GET);
        }

        public Times Time()
        {
            return Execute<Times>(TimeRequest());
        }

        public async Task<IRestResponse<Times>> TimeAsync()
        {
            return await restClient.ExecuteTaskAsync<Times>(TimeRequest());
        }

        private RestRequest NodeInfoRequest()
        {
            return new RestRequest("/api/v1/node-info", Method.GET);
        }

        public Infos NodeInfo()
        {
            return Execute<Infos>(NodeInfoRequest());
        }

        public async Task<IRestResponse<Infos>> NodeInfoAsync()
        {
            return await restClient.ExecuteTaskAsync<Infos>(NodeInfoRequest());
        }

        private RestRequest ValidatorsRequest()
        {
            return new RestRequest("/api/v1/validators", Method.GET);
        }

        public Validator Validators()
        {
            return Execute<Validator>(ValidatorsRequest());
        }

        public async Task<IRestResponse<Validator>> ValidatorsAsync()
        {
            return await restClient.ExecuteTaskAsync<Validator>(ValidatorsRequest());
        }

        private RestRequest PeersRequest()
        {
            return new RestRequest("/api/v1/peers", Method.GET);
        }

        public List<Peer> Peers()
        {
            return Execute<List<Peer>>(PeersRequest());
        }

        public async Task<IRestResponse<List<Peer>>> PeersAsync()
        {
            return await restClient.ExecuteTaskAsync<List<Peer>>(PeersRequest());
        }

        private RestRequest AccountRequest(string address)
        {
            return new RestRequest($"/api/v1/account/{address}", Method.GET);
        }

        /// <summary>
        /// address 	path 	The account address to query 	Yes 	string
        /// </summary>
        /// <param name="address"></param>
        public Account Account(string address)
        {
            return Execute<Account>(AccountRequest(address));
        }

        public async Task<IRestResponse<Account>> AccountAsync(string address)
        {
            return await restClient.ExecuteTaskAsync<Account>(AccountRequest(address));
        }

        private RestRequest AccountSequenceRequest(string address)
        {
            return new RestRequest($"/api/v1/account/{address}/sequence", Method.GET);
        }

        /// <summary>
        /// address 	path 	The account address to query 	Yes 	string
        /// </summary>
        /// <param name="address"></param>
        public AccountSequence AccountSequence(string address)
        {
            return Execute<AccountSequence>(AccountSequenceRequest(address));
        }

        public async Task<IRestResponse<AccountSequence>> AccountSequenceAsync(string address)
        {
            return await restClient.ExecuteTaskAsync<AccountSequence>(AccountSequenceRequest(address));
        }

        private RestRequest TxRequest(string hash, bool raw = true)
        {
            var request = new RestRequest($"/api/v1/tx/{hash}", Method.GET);
            if (!raw)
            {
                request.AddQueryParameter("format", "json");
            }
            return request;
        }

        /// <summary>
        /// hash 	path 	The transaction hash to query 	Yes 	string
        /// format query   Response format(json or omit)
        /// </summary>
        /// <param name="hash"></param>
        public Transaction Tx(string hash, bool raw = true)
        {
            return Execute<Transaction>(TxRequest(hash, raw));
        }

        public async Task<IRestResponse<Transaction>> TxAsync(string hash, bool raw = true)
        {
            return await restClient.ExecuteTaskAsync<Transaction>(TxRequest(hash, raw));
        }

        private RestRequest TokensRequest(int limit = 500, int offset = 0)
        {
            var request = new RestRequest("/api/v1/tokens", Method.GET);
            request.AddQueryParameter("limit", limit.ToString());
            request.AddQueryParameter("offset", offset.ToString());
            return request;
        }

        /// <summary>
        /// limit 	query 	default 500; max 1000. 	No 	integer
        /// offset 	query 	start with 0; default 0. 	No 	integer
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        public List<Token> Tokens(int limit = 500, int offset = 0)
        {
            return Execute<List<Token>>(TokensRequest(limit, offset));
        }

        public async Task<IRestResponse<List<Token>>> TokensAsync(int limit = 500, int offset = 0)
        {
            return await restClient.ExecuteTaskAsync<List<Token>>(TokensRequest(limit, offset));
        }

        private RestRequest MarketsRequest(int limit = 500, int offset = 0)
        {
            var request = new RestRequest("/api/v1/markets", Method.GET);
            request.AddQueryParameter("limit", limit.ToString());
            request.AddQueryParameter("offset", offset.ToString());
            return request;
        }

        /// <summary>
        /// limit 	query 	default 500; max 1000. 	No 	integer
        /// offset 	query 	start with 0; default 0. 	No 	integer
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        public List<Market> Markets(int limit = 500, int offset = 0)
        {
            return Execute<List<Market>>(MarketsRequest(limit, offset));
        }

        public async Task<IRestResponse<List<Market>>> MarketsAsync(int limit = 500, int offset = 0)
        {
            return await restClient.ExecuteTaskAsync<List<Market>>(MarketsRequest(limit, offset));
        }

        private RestRequest FeesRequest()
        {
            return new RestRequest("/api/v1/fees", Method.GET);
        }

        public List<FeeData> Fees()
        {
            return Execute<List<FeeData>>(FeesRequest());
        }

        public async Task<IRestResponse<List<FeeData>>> FeesAsync()
        {
            return await restClient.ExecuteTaskAsync<List<FeeData>>(FeesRequest());
        }

        private RestRequest DepthRequest(string symbol, int limit = 5)
        {
            var request = new RestRequest("/api/v1/depth", Method.GET);
            request.AddQueryParameter("symbol", symbol);
            request.AddQueryParameter("limit", limit.ToString());
            return request;
        }

        /// <summary>
        /// symbol 	query 	Market pair symbol, e.g. NNB-0AD_BNB 	Yes 	string
        /// limit 	query 	The limit of results. Allowed limits: [5, 10, 20, 50, 100, 500, 1000] 	No 	integer
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="limit"></param>
        public MarketDepth Depth(string symbol, int limit = 5)
        {
            return Execute<MarketDepth>(DepthRequest(symbol, limit));
        }

        public async Task<IRestResponse<MarketDepth>> DepthAsync(string symbol, int limit = 5)
        {
            return await restClient.ExecuteTaskAsync<MarketDepth>(DepthRequest(symbol, limit));
        }

        private RestRequest BroadcastRequest(string body, bool sync = true)
        {
            var request = new RestRequest("/api/v1/broadcast", Method.POST);
            request.RequestFormat = DataFormat.None;
            request.AddHeader("Content-Type", "text/plain; charset=utf-8");
            request.AddParameter("POST", body, "text/plain; charset=utf-8", ParameterType.RequestBody);
            return request;
        }

        /// <summary>
        /// Description: Broadcasts a signed transaction. A single transaction must be sent hex-encoded with a content-type of text/plain
        /// sync 	query 	Synchronous broadcast (wait for DeliverTx)? 	No 	boolean
        /// body 	body 		Yes 	binary
        /// </summary>
        /// <param name="body"></param>
        public List<TransactionMetadata> Broadcast(string body, bool sync = true)
        {
            return Execute<List<TransactionMetadata>>(BroadcastRequest(body, sync));
        }

        public async Task<IRestResponse<List<TransactionMetadata>>> BroadcastAsync(string body, bool sync = true)
        {
            return await restClient.ExecuteTaskAsync<List<TransactionMetadata>>(BroadcastRequest(body, sync));
        }

        private RestRequest KLinesRequest(string symbol, string interval, int limit = 300, long? startTime = null, long? endTime = null)
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
            return request;
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
            return Execute<List<List<object>>>(KLinesRequest(symbol, interval, limit, startTime, endTime));
        }

        public async Task<IRestResponse<List<List<object>>>> KLinesAsync(string symbol, string interval, int limit = 300, long? startTime = null, long? endTime = null)
        {
            return await restClient.ExecuteTaskAsync<List<List<object>>>(KLinesRequest(symbol, interval, limit, startTime, endTime));
        }

        private RestRequest ClosedRequest(string address, long? end = null, int limit = 500, int offset = 0, int? side = null, long? start = null, string status = null, string symbol = null, int? total = null)
        {
            var request = new RestRequest("/api/v1/orders/closed", Method.GET);
            request.AddQueryParameter("address", address);
            if (end.HasValue)
            {
                request.AddQueryParameter("end", end.ToString());
            }
            request.AddQueryParameter("limit", limit.ToString());
            request.AddQueryParameter("offset", offset.ToString());
            if (side.HasValue)
            {
                request.AddQueryParameter("side", side.ToString());
            }
            if (start.HasValue)
            {
                request.AddQueryParameter("start", start.ToString());
            }
            if (!string.IsNullOrWhiteSpace(status))
            {
                request.AddQueryParameter("status", status);
            }
            if (!string.IsNullOrWhiteSpace(symbol))
            {
                request.AddQueryParameter("symbol", symbol);
            }
            if (total.HasValue)
            {
                request.AddQueryParameter("total", total.ToString());
            }
            return request;
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
        public OrderList Closed(string address, long? end = null, int limit = 500, int offset = 0, int? side = null, long? start = null, string status = null, string symbol = null, int? total = null)
        {
            return Execute<OrderList>(ClosedRequest(address, end, limit, offset, side, start, status, symbol, total));
        }

        public async Task<IRestResponse<OrderList>> ClosedAsync(string address, long? end = null, int limit = 500, int offset = 0, int? side = null, long? start = null, string status = null, string symbol = null, int? total = null)
        {
            return await restClient.ExecuteTaskAsync<OrderList>(ClosedRequest(address, end, limit, offset, side, start, status, symbol, total));
        }

        private RestRequest OpenRequest(string address, int limit = 500, int offset = 0, string symbol = null, int? total = null)
        {
            var request = new RestRequest("/api/v1/orders/open", Method.GET);
            request.AddQueryParameter("address", address);
            request.AddQueryParameter("limit", limit.ToString());
            request.AddQueryParameter("offset", offset.ToString());
            if (!string.IsNullOrWhiteSpace(symbol))
            {
                request.AddQueryParameter("symbol", symbol);
            }
            if (total.HasValue)
            {
                request.AddQueryParameter("total", total.ToString());
            }
            return request;
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
        public OrderList Open(string address, int limit = 500, int offset = 0, string symbol = null, int? total = null)
        {
            return Execute<OrderList>(OpenRequest(address, limit, offset, symbol, total));
        }

        public async Task<IRestResponse<OrderList>> OpenAsync(string address, int limit = 500, int offset = 0, string symbol = null, int? total = null)
        {
            return await restClient.ExecuteTaskAsync<OrderList>(OpenRequest(address, limit, offset, symbol, total));
        }

        private RestRequest OrdersRequest(string id)
        {
            return new RestRequest($"/api/v1/orders/{id}", Method.GET);
        }

        /// <summary>
        /// id 	path 	order id 	Yes 	string
        /// </summary>
        /// <param name="id"></param>
        public Order Orders(string id)
        {
            return Execute<Order>(OrdersRequest(id));
        }

        public async Task<IRestResponse<Order>> OrdersAsync(string id)
        {
            return await restClient.ExecuteTaskAsync<Order>(OrdersRequest(id));
        }

        private RestRequest Ticker24hrRequest(string symbol = null)
        {
            var request = new RestRequest("/api/v1/ticker/24hr", Method.GET);
            if (!string.IsNullOrWhiteSpace(symbol))
            {
                request.AddQueryParameter("symbol", symbol);
            }
            return request;
        }

        /// <summary>
        /// symbol 	query 	symbol 	No 	string
        /// </summary>
        /// <param name="symbol"></param>
        public List<TickerStatistics> Ticker24hr(string symbol = null)
        {
            return Execute<List<TickerStatistics>>(Ticker24hrRequest(symbol));
        }

        public async Task<IRestResponse<List<TickerStatistics>>> Ticker24hrAsync(string symbol = null)
        {
            return await restClient.ExecuteTaskAsync<List<TickerStatistics>>(Ticker24hrRequest(symbol));
        }

        private RestRequest TradesRequest(string address = null, string buyerOrderId = null, long? end = null, long? height = null, int limit = 500, int offset = 0, string quoteAsset = null, string sellerOrderId = null, int? side = null, long? start = null, string symbol = null, int? total = null)
        {
            var request = new RestRequest("/api/v1/trades", Method.GET);
            if (!string.IsNullOrWhiteSpace(address))
            {
                request.AddQueryParameter("address", address);
            }
            if (!string.IsNullOrWhiteSpace(buyerOrderId))
            {
                request.AddQueryParameter("buyerOrderId", buyerOrderId);
            }
            if (end.HasValue)
            {
                request.AddQueryParameter("end", end.ToString());
            }
            if (height.HasValue)
            {
                request.AddQueryParameter("height", height.ToString());
            }
            request.AddQueryParameter("limit", limit.ToString());
            request.AddQueryParameter("offset", offset.ToString());
            if (!string.IsNullOrWhiteSpace(quoteAsset))
            {
                request.AddQueryParameter("quoteAsset", quoteAsset);
            }
            if (!string.IsNullOrWhiteSpace(sellerOrderId))
            {
                request.AddQueryParameter("sellerOrderId", sellerOrderId);
            }
            if (side.HasValue)
            {
                request.AddQueryParameter("side", side.ToString());
            }
            if (start.HasValue)
            {
                request.AddQueryParameter("start", start.ToString());
            }
            if (!string.IsNullOrWhiteSpace(symbol))
            {
                request.AddQueryParameter("symbol", symbol);
            }
            if (total.HasValue)
            {
                request.AddQueryParameter("total", total.ToString());
            }
            return request;
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
        /// <param name="sellerOrderId"></param>
        /// <param name="side"></param>
        /// <param name="start"></param>
        /// <param name="symbol"></param>
        /// <param name="total"></param>
        public TradePage Trades(string address = null, string buyerOrderId = null, long? end = null, long? height = null, int limit = 500, int offset = 0, string quoteAsset = null, string sellerOrderId = null, int? side = null, long? start = null, string symbol = null, int? total = null)
        {
            return Execute<TradePage>(TradesRequest(address, buyerOrderId, end, height, limit, offset, quoteAsset, sellerOrderId, side, start, symbol, total));
        }

        public async Task<IRestResponse<TradePage>> TradesAsync(string address = null, string buyerOrderId = null, long? end = null, long? height = null, int limit = 500, int offset = 0, string quoteAsset = null, string sellerOrderId = null, int? side = null, long? start = null, string symbol = null, int? total = null)
        {
            return await restClient.ExecuteTaskAsync<TradePage>(TradesRequest(address, buyerOrderId, end, height, limit, offset, quoteAsset, sellerOrderId, side, start, symbol, total));
        }

        private RestRequest TransactionsRequest(string address, long? blockHeight = null, long? endTime = null, int? limit = null, int? offset = null, string side = null, long? startTime = null, string txAsset = null, string txType = null)
        {
            var request = new RestRequest("/api/v1/transactions", Method.GET);
            request.AddQueryParameter("address", address);
            if (blockHeight.HasValue)
            {
                request.AddQueryParameter("blockHeight", blockHeight.ToString());
            }
            if (endTime.HasValue)
            {
                request.AddQueryParameter("endTime", endTime.ToString());
            }
            if (limit.HasValue)
            {
                request.AddQueryParameter("limit", limit.ToString());
            }
            if (offset.HasValue)
            {
                request.AddQueryParameter("offset", offset.ToString());
            }
            if (!string.IsNullOrWhiteSpace(side))
            {
                request.AddQueryParameter("side", side);
            }
            if (startTime.HasValue)
            {
                request.AddQueryParameter("startTime", startTime.ToString());
            }
            if (!string.IsNullOrWhiteSpace(txAsset))
            {
                request.AddQueryParameter("txAsset", txAsset);
            }
            if (!string.IsNullOrWhiteSpace(txType))
            {
                request.AddQueryParameter("txType", txType);
            }
            return request;
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
        public TxPage Transactions(string address, long? blockHeight = null, long? endTime = null, int? limit = null, int? offset = null, string side = null, long? startTime = null, string txAsset = null, string txType = null)
        {
            return Execute<TxPage>(TransactionsRequest(address, blockHeight, endTime, limit, offset, side, startTime, txAsset, txType));
        }

        public async Task<IRestResponse<TxPage>> TransactionsAsync(string address, long? blockHeight = null, long? endTime = null, int? limit = null, int? offset = null, string side = null, long? startTime = null, string txAsset = null, string txType = null)
        {
            return await restClient.ExecuteTaskAsync<TxPage>(TransactionsRequest(address, blockHeight, endTime, limit, offset, side, startTime, txAsset, txType));
        }
    }
}
