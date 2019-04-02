using binance.dex.sdk.httpapi;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace binance.dex.sdk.test
{
    public class TimeTest
    {
        private readonly ILogger _output;

        public TimeTest(ITestOutputHelper output)
        {
            // Pass the ITestOutputHelper object to the TestOutput sink
            _output = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.TestOutput(output, Serilog.Events.LogEventLevel.Verbose)
                .CreateLogger()
                .ForContext<HttpApiClient>();
        }

        [Fact]
        public void RequestTimeTest()
        {
            /*Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .CreateLogger();*/

            HttpApiClient client = new HttpApiClient(BinanceDexEnvironment.TEST_NET);
            client.Time();
            Debug.WriteLine("lalalaal");
            _output.Information("Test output to Serilog!");
            Log.Information("kfsfsf ");
        }
    }
}
