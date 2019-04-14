using binance.dex.sdk.websocket.stream;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocketRPC;

namespace binance.dex.sdk.websocket
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

    public enum EKLineInterval
    {
        Minute1, Minute3, Minute5, Minute15, Minute30, Hour1, Hour2, Hour4, Hour6, Hour8, Hour12, Day1, Day3, Week1, Month1
    }

    public class KLineInterval
    {
        private const string Minute1 = "1m";
        private const string Minute3 = "3m";
        private const string Minute5 = "5m";
        private const string Minute15 = "15m";
        private const string Minute30 = "30m";
        private const string Hour1 = "1h";
        private const string Hour2 = "2h";
        private const string Hour4 = "4h";
        private const string Hour6 = "6h";
        private const string Hour8 = "8h";
        private const string Hour12 = "12h";
        private const string Day1 = "1d";
        private const string Day3 = "3d";
        private const string Week1 = "1w";
        private const string Month1 = "1M";

        public static string ToKLineInterval(EKLineInterval kLineInterval)
        {
            switch (kLineInterval)
            {
                case EKLineInterval.Minute1:
                    return Minute1;
                case EKLineInterval.Minute3:
                    return Minute3;
                case EKLineInterval.Minute5:
                    return Minute5;
                case EKLineInterval.Minute15:
                    return Minute15;
                case EKLineInterval.Minute30:
                    return Minute30;
                case EKLineInterval.Hour1:
                    return Hour1;
                case EKLineInterval.Hour2:
                    return Hour2;
                case EKLineInterval.Hour4:
                    return Hour4;
                case EKLineInterval.Hour6:
                    return Hour6;
                case EKLineInterval.Hour8:
                    return Hour8;
                case EKLineInterval.Hour12:
                    return Hour12;
                case EKLineInterval.Day1:
                    return Day1;
                case EKLineInterval.Day3:
                    return Day3;
                case EKLineInterval.Week1:
                    return Week1;
                case EKLineInterval.Month1:
                    return Month1;
                default:
                    throw new WebSocketException($"Unhandled kLineInterval: {kLineInterval}");
            }
        }
    }

    public class Streams
    {
        public static string Orders(string address)
        {
            return $"ws/{address}";
        }

        public static string Accounts(string address)
        {
            return $"ws/{address}";
        }

        public static string Transfers(string address)
        {
            return $"ws/{address}";
        }

        public static string Trades(string symbol)
        {
            return $"ws/{symbol}@trades";
        }

        public static string MarketDiff(string symbol)
        {
            return $"ws/{symbol}@marketDiff";
        }

        public static string MarketDepth(string symbol)
        {
            return $"ws/{symbol}@marketDepth";
        }

        public static string KLine(string symbol, string interval)
        {
            return $"ws/{symbol}@kline_{interval}";
        }

        public static string Ticker(string symbol)
        {
            return $"ws/{symbol}@ticker";
        }

        public static string AllTickers()
        {
            return $"ws/$all@allTickers";
        }

        public static string MiniTicker(string symbol)
        {
            return $"ws/{symbol}@miniTicker";
        }

        public static string AllMiniTickers(string symbol)
        {
            return $"ws/$all@allMiniTickers";
        }

        public static string Blockheight()
        {
            return $"ws/$all@blockheight";
        }

        /*
        Single streams may be accessed at /ws/\<streamName>
        Combined streams may be accessed at /stream?streams=\<streamName1>/\<streamName2>/\<streamName3> (etc.)

        // for personal streams, ex: Account & Orders & Transfers
        const accountAndOrdersFeeds = new WebSocket("wss://testnet-dex.binance.org/api/ws/<USER_ADDRESS>");

        // for single streams
        const tradesFeeds = new WebSocket("wss://testnet-dex.binance.org/api/ws/<symbol>@trades");
        const marketFeeds = new WebSocket("wss://testnet-dex.binance.org/api/ws/<symbol>@marketDiff");
        const deltaFeeds = new WebSocket("wss://testnet-dex.binance.org/api/ws/<symbol>@marketDepth");
  
        // for all symbols
        const allTickers = new WebSocket("wss://testnet-dex.binance.org/api/ws/$all@allTickers");
        const allMiniTickers = new WebSocket("wss://testnet-dex.binance.org/api/ws/$all@allMiniTickers");
        const blockHeight = new WebSocket("wss://testnet-dex.binance.org/api/ws/$all@blockheight");

        // for combined streams, can combined a mixed symbols and streams
        const combinedFeeds = new WebSocket("wss://testnet-dex.binance.org/api/stream?streams=<symbol>@trades/<symbol>@marketDepth/<symbol>@marketDiff");
        */
    }

    /*
     Note: Once the connection is established, websocket server would send ping frame to client every 30 seconds.
     Client should response pong frame in time (this has already implemented by most mordern browers,
     but programmatical users need be aware of whether your websocket library support this), otherwise,
     the connection might be closed.
    */

    public class WebSocketClient
    {

        /*
         * WebSocket Streams:
         * Orders
         * Account
         * Transfer
         * Trades
         * Diff. Depth Stream
         * Book Depth Streams
         * Kline/Candlestick Streams
         * Individual Symbol Ticker Streams
         * All Symbols Ticker Streams
         * Individual Symbol Mini Ticker Streams
         * All Symbols Mini Ticker Streams
         * Blockheight
        */

        public BinanceDexEnvironmentData Env { get; set; }

        public ETopic Topic { get; set; }

        public string Address { get; set; }

        public string Symbol { get; set; }

        public EKLineInterval KLineInterval { get; set; }

        public bool Reconnect { get; set; }

        public string Url { get; set; }

        public event EventHandler<IStreamData> StreamData;

        public bool IsOpen { get; set; }

        public bool IsError { get; set; }

        private void BuildUrl()
        {
            switch (Topic)
            {
                case ETopic.Orders:
                    Url = $"{Env.WsBaseUrl}{Streams.Orders(Address)}";
                    break;
                case ETopic.Accounts:
                    Url = $"{Env.WsBaseUrl}{Streams.Accounts(Address)}";
                    break;
                case ETopic.Transfers:
                    Url = $"{Env.WsBaseUrl}{Streams.Transfers(Address)}";
                    break;
                case ETopic.Trades:
                    Url = $"{Env.WsBaseUrl}{Streams.Trades(Symbol)}";
                    break;
                case ETopic.MarketDiff:
                    Url = $"{Env.WsBaseUrl}{Streams.MarketDiff(Symbol)}";
                    break;
                case ETopic.MarketDepth:
                    Url = $"{Env.WsBaseUrl}{Streams.MarketDepth(Symbol)}";
                    break;
                case ETopic.KLine:
                    Url = $"{Env.WsBaseUrl}{Streams.KLine(Symbol, websocket.KLineInterval.ToKLineInterval(KLineInterval))}";
                    break;
                case ETopic.Ticker:
                    Url = $"{Env.WsBaseUrl}{Streams.Ticker(Symbol)}";
                    break;
                case ETopic.AllTickers:
                    Url = $"{Env.WsBaseUrl}{Streams.AllTickers()}";
                    break;
                case ETopic.MiniTicker:
                    Url = $"{Env.WsBaseUrl}{Streams.MiniTicker(Symbol)}";
                    break;
                case ETopic.AllMiniTickers:
                    Url = $"{Env.WsBaseUrl}{Streams.AllMiniTickers(Symbol)}";
                    break;
                case ETopic.Blockheight:
                    Url = $"{Env.WsBaseUrl}{Streams.Blockheight()}";
                    break;
                default:
                    throw new WebSocketException($"Unhandled Topic: {Topic}");
            }
        }

        public void Connect()
        {
            BuildUrl();
            IsOpen = true;
            IsError = false;
            Client.ConnectAsync(Url, CancellationToken.None, c =>
            {
                c.OnOpen += OnOpen;
                c.OnClose += OnClose;
                c.OnError += OnError;
                c.OnReceive += OnReceive;
            }, Reconnect, Reconnect, 1).Wait(0);
        }

        private Task OnOpen()
        {
            IsOpen = true;
            return Task.CompletedTask;
        }

        private Task OnClose(WebSocketCloseStatus status, string description)
        {
            IsOpen = false;
            return Task.CompletedTask;
        }

        private Task OnError(Exception exception)
        {
            IsOpen = false;
            IsError = false;
            return Task.CompletedTask;
        }

        private Task OnReceive(string message)
        {
            var jObject = JObject.Parse(message);
            string stream = jObject.Value<string>("stream");
            IStreamData streamData = null;
            if (stream == websocket.Topic.ToTopic(ETopic.Blockheight))
            {
                streamData = JsonConvert.DeserializeObject<BlockheightPayload>(message).Data;
                //streamData = jObject.Value<Blockheight>("data");
            }
            StreamData(this, streamData);
            return Task.CompletedTask;
        }
    }
}
