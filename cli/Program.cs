using binance.dex.sdk.websocket;
using binance.dex.sdk.websocket.stream;
using Serilog;
using System;
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
            client.Topic = websocket.ETopic.Blockheight;
            client.StreamData += OnStreamData;
            client.Connect();

            Console.ReadLine();
        }

        private static void OnStreamData(object sender, IStreamData data)
        {
            Blockheight blockheight = (Blockheight)data;
            Console.WriteLine(blockheight.BlockHeight);
            Log.Information($"BlockHeight: {blockheight.BlockHeight}");
        }
    }
}
