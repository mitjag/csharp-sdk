using Serilog;
using System;

namespace binance.dex.sdk.cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            Log.Information("No one listens to me!");
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
