using binance.dex.sdk.websocket;
using binance.dex.sdk.websocket.stream;
using Serilog;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using WebSocketRPC;

namespace binance.dex.sdk.cli
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            Log.Information("No one listens to me!");
            Console.WriteLine("Hello World!");

            WebSocketClient client = new WebSocketClient();
            client.Env = BinanceDexEnvironment.TEST_NET;
            //client.Topic = ETopic.Blockheight;
            //client.Topic = ETopic.AllTickers;
            //client.Symbol = "BNB_BTC";
            //client.Topic = ETopic.AllMiniTickers;
            client.Topics = new List<ETopic> { ETopic.Blockheight, ETopic.AllMiniTickers };
            client.StreamData += OnStreamData;
            client.Connect();
            Console.WriteLine($"Url: {client.Url}");
            Console.ReadLine();
        }

        private static void OnStreamData(object sender, IStreamData data)
        {
            if (data.Topic == ETopic.Blockheight)
            {
                Blockheight blockheight = (Blockheight)data;
                Console.WriteLine(blockheight.BlockHeight);
                Log.Information($"BlockHeight: {blockheight.BlockHeight}");
            }
            else if (data.Topic == ETopic.AllTickers)
            {
                AllTickersData allTickersData = (AllTickersData)data;
                Console.WriteLine(allTickersData.AllTickers[0].Symbol);
            }
            else if (data.Topic == ETopic.AllMiniTickers)
            {
                AllMiniTickersData allMiniTickersData = (AllMiniTickersData)data;
                Console.WriteLine(allMiniTickersData.AllMiniTickers[0].Symbol);
            }
        }
    }
}
