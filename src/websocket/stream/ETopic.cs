using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket.stream
{
    public enum ETopic
    {
        Orders, Accounts, Transfers, Trades, MarketDiff, MarketDepth, KLine, Ticker, AllTickers, MiniTicker, AllMiniTickers, Blockheight
    }

    public class Topic
    {
        // Topic Name: orders | Stream: /ws/userAddress
        private const string Orders = "orders";

        // Topic Name: accounts | Stream: /ws/userAddress
        private const string Accounts = "accounts";

        // Topic Name: transfers | Stream: /ws/userAddress
        private const string Transfers = "transfers";

        // Topic Name: trades | Stream: \<symbol>@trades
        private const string Trades = "trades";

        // Topic Name: marketDiff | Stream: \<symbol>@marketDiff
        private const string MarketDiff = "marketDiff";

        // Topic Name: marketDepth | Stream: \<symbol>@marketDepth
        private const string MarketDepth = "marketDepth";

        // Topic Name: kline_\<interval> | Stream: \<symbol>@kline_\<interval>
        private const string KLine = "kline";

        // Topic Name: ticker | Stream: \<symbol>@ticker
        private const string Ticker = "ticker";

        // Topic Name: allTickers | Stream: $all@allTickers
        private const string AllTickers = "allTickers";

        // Topic Name: miniTicker | Stream: \<symbol>@miniTicker
        private const string MiniTicker = "miniTicker";

        // Topic Name: allMiniTickers | Stream: $all@allMiniTickers
        private const string AllMiniTickers = "allMiniTickers";

        // Topic Name: blockheight | Stream: $all@blockheight
        private const string Blockheight = "blockheight";

        public static string ToTopic(ETopic topic)
        {
            switch (topic)
            {
                case ETopic.Orders:
                    return Orders;
                case ETopic.Accounts:
                    return Accounts;
                case ETopic.Transfers:
                    return Transfers;
                case ETopic.Trades:
                    return Trades;
                case ETopic.MarketDiff:
                    return MarketDiff;
                case ETopic.MarketDepth:
                    return MarketDepth;
                case ETopic.KLine:
                    return KLine;
                case ETopic.Ticker:
                    return Ticker;
                case ETopic.AllTickers:
                    return AllTickers;
                case ETopic.MiniTicker:
                    return MiniTicker;
                case ETopic.AllMiniTickers:
                    return AllMiniTickers;
                case ETopic.Blockheight:
                    return Blockheight;
                default:
                    throw new WebSocketException($"Unhandled topic: {topic}");
            }
        }
    }
}
