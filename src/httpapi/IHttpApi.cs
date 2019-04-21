using binance.dex.sdk.broadcast;
using binance.dex.sdk.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.httpapi
{
    /// <summary>
    /// The Binance Chain HTTP API provides access to a Binance Chain node deployment and market data services.
    /// https://binance-chain.github.io/api-reference/dex-api/paths.html
    /// </summary>
    public interface IHttpApi
    {
        Times Time();

        Infos NodeInfo();

        Validator Validators();

        List<Peer> Peers();

        Account Account(string address);

        AccountSequence AccountSequence(string address);

        Transaction Tx(string hash, bool raw = true);

        List<Token> Tokens(int limit = 500, int offset = 0);

        List<Market> Markets(int limit = 500, int offset = 0);

        List<FeeData> Fees();

        MarketDepth Depth(string symbol, int limit = 5);

        List<TransactionMetadata> Broadcast(string body, bool sync = true);

        List<List<object>> KLines(string symbol, string interval, int limit = 300, long? startTime = null, long? endTime = null);

        OrderList Closed(string address, long? end = null, int limit = 500, int offset = 0, int? side = null, long? start = null, string status = null, string symbol = null, int? total = null);

        OrderList Open(string address, int limit = 500, int offset = 0, string symbol = null, int? total = null);

        Order Orders(string id);

        List<TickerStatistics> Ticker24hr(string symbol = null);

        TradePage Trades(string address = null, string buyerOrderId = null, long? end = null, long? height = null, int limit = 500, int offset = 0, string quoteAsset = null, string seelerOrderId = null, int? side = null, long? start = null, string symbol = null, int? total = null);

        TxPage Transactions(string address, long? blockHeight = null, long? endTime = null, int? limit = null, int? offset = null, string side = null, long? startTime = null, string txAsset = null, string txType = null);
    }
}
