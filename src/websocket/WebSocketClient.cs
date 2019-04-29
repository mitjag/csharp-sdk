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
    /// <summary>
    ///  WebSocket Streams:
    ///  Orders, Account, Transfer, Trades,
    ///  Diff.Depth Stream, Book Depth Streams, Kline/Candlestick Streams, Individual Symbol Ticker Streams,
    ///  All Symbols Ticker Streams, Individual Symbol Mini Ticker Streams, All Symbols Mini Ticker Streams, Blockheight
    /// </summary>
    public class Streams
    {
        public static string Orders(string address)
        {
            return $"{address}";
        }

        public static string Accounts(string address)
        {
            return $"{address}";
        }

        public static string Transfers(string address)
        {
            return $"{address}";
        }

        public static string Trades(string symbol)
        {
            return $"{symbol}@trades";
        }

        public static string MarketDiff(string symbol)
        {
            return $"{symbol}@marketDiff";
        }

        public static string MarketDepth(string symbol)
        {
            return $"{symbol}@marketDepth";
        }

        public static string KLine(string symbol, string interval)
        {
            return $"{symbol}@kline_{interval}";
        }

        public static string Ticker(string symbol)
        {
            return $"{symbol}@ticker";
        }

        public static string AllTickers()
        {
            return $"$all@allTickers";
        }

        public static string MiniTicker(string symbol)
        {
            return $"{symbol}@miniTicker";
        }

        public static string AllMiniTickers()
        {
            return $"$all@allMiniTickers";
        }

        public static string Blockheight()
        {
            return $"$all@blockheight";
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

    public class WebSocketClient : IWebSocket
    {
        public BinanceDexEnvironmentData Env { get; set; }

        public ETopic Topic { get; set; }

        public List<ETopic> Topics { get; set; }

        public string Address { get; set; }

        public string Symbol { get; set; }

        public EKLineInterval KLineInterval { get; set; }

        public bool Reconnect { get; set; }

        public string Url { get; set; }

        public event EventHandler<IStreamData> StreamData;

        public bool IsOpen { get; set; }

        public bool IsError { get; set; }

        private string ToUrl(ETopic topic)
        {
            switch (topic)
            {
                case ETopic.Orders:
                    return Streams.Orders(Address);
                case ETopic.Accounts:
                    return Streams.Accounts(Address);
                case ETopic.Transfers:
                    return Streams.Transfers(Address);
                case ETopic.Trades:
                    return Streams.Trades(Symbol);
                case ETopic.MarketDiff:
                    return Streams.MarketDiff(Symbol);
                case ETopic.MarketDepth:
                    return Streams.MarketDepth(Symbol);
                case ETopic.KLine:
                    return Streams.KLine(Symbol, stream.KLineInterval.ToKLineInterval(KLineInterval));
                case ETopic.Ticker:
                    return Streams.Ticker(Symbol);
                case ETopic.AllTickers:
                    return Streams.AllTickers();
                case ETopic.MiniTicker:
                    return Streams.MiniTicker(Symbol);
                case ETopic.AllMiniTickers:
                    return Streams.AllMiniTickers();
                case ETopic.Blockheight:
                    return Streams.Blockheight();
                default:
                    throw new WebSocketException($"Unhandled Topic: {Topic}");
            }
        }

        private void BuildUrl()
        {
            Url = $"{Env.WsBaseUrl}stream?streams=";
            foreach (ETopic topic in Topics)
            {
                Url += $"{ToUrl(topic)}/";
            }
            Url = Url.Substring(0, Url.Length - 1);
        }

        public void Connect()
        {
            if (Topics == null || Topics.Count == 0)
            {
                // Single streams may be accessed at /ws/\<streamName>
                Url = $"{Env.WsBaseUrl}ws/{ToUrl(Topic)}";
            }
            else
            {
                // Combined streams may be accessed at /stream?streams=\<streamName1>/\<streamName2>/\<streamName3>
                BuildUrl();
            }
            
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
            if (stream == websocket.stream.Topic.ToTopic(ETopic.Orders))
            {
                streamData = new OrdersData { Orders = JsonConvert.DeserializeObject<Payload<List<Order>>>(message).Data };
            }
            else if (stream == websocket.stream.Topic.ToTopic(ETopic.Accounts))
            {
                streamData = new AccountsData { Accounts = JsonConvert.DeserializeObject<Payload<List<Account>>>(message).Data };
            }
            else if (stream == websocket.stream.Topic.ToTopic(ETopic.Transfers))
            {
                streamData = JsonConvert.DeserializeObject<Payload<TransfersData>>(message).Data;
            }
            else if (stream == websocket.stream.Topic.ToTopic(ETopic.Trades))
            {
                streamData = new TradesData { Trades = JsonConvert.DeserializeObject<Payload<List<Trade>>>(message).Data };
            }
            else if (stream == websocket.stream.Topic.ToTopic(ETopic.MarketDiff))
            {
                streamData = JsonConvert.DeserializeObject<Payload<MarketDiff>>(message).Data;
            }
            else if (stream == websocket.stream.Topic.ToTopic(ETopic.MarketDepth))
            {
                streamData = JsonConvert.DeserializeObject<Payload<MarketDepth>>(message).Data;
            }
            else if (stream == websocket.stream.Topic.ToTopic(ETopic.KLine))
            {
                streamData = JsonConvert.DeserializeObject<Payload<KLine>>(message).Data;
            }
            else if (stream == websocket.stream.Topic.ToTopic(ETopic.Ticker))
            {
                streamData = JsonConvert.DeserializeObject<Payload<Ticker>>(message).Data;
            }
            else if (stream == websocket.stream.Topic.ToTopic(ETopic.AllTickers))
            {
                streamData = new AllTickersData { AllTickers = JsonConvert.DeserializeObject<Payload<List<Ticker>>>(message).Data };
             }
            else if (stream == websocket.stream.Topic.ToTopic(ETopic.MiniTicker))
            {
                streamData = JsonConvert.DeserializeObject<Payload<MiniTicker>>(message).Data;
            }
            else if (stream == websocket.stream.Topic.ToTopic(ETopic.AllMiniTickers))
            {
                streamData = new AllMiniTickersData { AllMiniTickers = JsonConvert.DeserializeObject<Payload<List<MiniTicker>>>(message).Data };
            }
            else if (stream == websocket.stream.Topic.ToTopic(ETopic.Blockheight))
            {
                streamData = JsonConvert.DeserializeObject<Payload<Blockheight>>(message).Data;
            }
            else
            {
                throw new WebSocketException($"Unhandled topic stream: {stream}");
            }
            StreamData(this, streamData);
            return Task.CompletedTask;
        }
    }
}
