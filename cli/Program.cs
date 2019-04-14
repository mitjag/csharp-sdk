using Serilog;
using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using WebSocketRPC;
using WebSocketSharp;

namespace binance.dex.sdk.cli
{
    class Program
    {
        static void Main(string[] args)
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
                c.OnReceive += async msg => { Console.WriteLine(msg); /*await c.CloseAsync();*/ };
            }).Wait(0);

            /*ClientWebSocket webSocket = new ClientWebSocket();
            webSocket.ConnectAsync(new Uri(url), CancellationToken.None);
            Task.WhenAll(Receive(webSocket));*/

            /*using (var ws = new WebSocket(url))
            {
                ws.SslConfiguration.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) =>
                {
                    return true; // If the server certificate is valid.
                };
                ws.OnMessage += (sender, e) => Console.WriteLine("Biance DEX chain: " + e.Data);
                ws.Connect();
                //ws.Send(@"{""method"":""close""}");
            }*/

            Console.ReadLine();
        }

        private static async Task Receive(ClientWebSocket webSocket)
        {
            byte[] buffer = new byte[1024];
            while (webSocket.State == System.Net.WebSockets.WebSocketState.Open)
            {
                var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                if (result.MessageType == WebSocketMessageType.Close)
                {
                    await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
                }
                else
                {
                    Console.WriteLine("{0} {1}", result.Count, buffer);
                }
            }
        }
    }
}
