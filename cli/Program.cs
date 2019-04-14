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

            string url = "wss://testnet-dex.binance.org/api/ws/$all@blockheight";
            Console.WriteLine("Biance DEX chain");

            Client.ConnectAsync(url, CancellationToken.None, c =>
            {
                c.OnOpen += () => new Task(() => Console.WriteLine("Opened"));
                c.OnClose += (s, d) => new Task(() => Console.WriteLine("Closed: " + s));
                c.OnError += err => new Task(() => Console.WriteLine("Error: " + err.Message));
                //c.OnReceive += async msg => { Console.WriteLine(msg); /*await c.CloseAsync();*/ };
                c.OnReceive += StreamOnReceive;
            }).Wait(0);

            Console.ReadLine();
        }

        private static Task StreamOnReceive(string arg)
        {
            Console.WriteLine(arg);
            return Task.CompletedTask;
        }
    }
}
