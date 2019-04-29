using binance.dex.sdk.broadcast;
using binance.dex.sdk.model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace binance.dex.sdk.httpapi
{
    /// <summary>
    /// The Binance Chain HTTP API provides access to a Binance Chain node deployment and market data services.
    /// https://binance-chain.github.io/api-reference/dex-api/paths.html
    /// </summary>
    public interface IHttpApiAsync
    {
        Task<IRestResponse<Times>> TimeAsync();

        Task<IRestResponse<Infos>> NodeInfoAsync();

        Task<IRestResponse<Validator>> ValidatorsAsync();

        Task<IRestResponse<List<Peer>>> PeersAsync();

        Task<IRestResponse<Account>> AccountAsync(string address);

        Task<IRestResponse<AccountSequence>> AccountSequenceAsync(string address);

        Task<IRestResponse<Transaction>> TxAsync(string hash, bool raw = true);

        Task<IRestResponse<List<Token>>> TokensAsync(int limit = 500, int offset = 0);

        Task<IRestResponse<List<Market>>> MarketsAsync(int limit = 500, int offset = 0);

        Task<IRestResponse<List<FeeData>>> FeesAsync();

        Task<IRestResponse<MarketDepth>> DepthAsync(string symbol, int limit = 5);

        Task<IRestResponse<List<TransactionMetadata>>> BroadcastAsync(string body, bool sync = true);

        Task<IRestResponse<List<List<object>>>> KLinesAsync(string symbol, string interval, int limit = 300, long? startTime = null, long? endTime = null);

        Task<IRestResponse<OrderList>> ClosedAsync(string address, long? end = null, int limit = 500, int offset = 0, int? side = null, long? start = null, string status = null, string symbol = null, int? total = null);

        Task<IRestResponse<OrderList>> OpenAsync(string address, int limit = 500, int offset = 0, string symbol = null, int? total = null);

        Task<IRestResponse<Order>> OrdersAsync(string id);

        Task<IRestResponse<List<TickerStatistics>>> Ticker24hrAsync(string symbol = null);

        Task<IRestResponse<TradePage>> TradesAsync(string address = null, string buyerOrderId = null, long? end = null, long? height = null, int limit = 500, int offset = 0, string quoteAsset = null, string seelerOrderId = null, int? side = null, long? start = null, string symbol = null, int? total = null);

        Task<IRestResponse<TxPage>> TransactionsAsync(string address, long? blockHeight = null, long? endTime = null, int? limit = null, int? offset = null, string side = null, long? startTime = null, string txAsset = null, string txType = null);
    }
}
