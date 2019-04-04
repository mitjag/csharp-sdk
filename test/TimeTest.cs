using binance.dex.sdk.httpapi;
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
        [Fact]
        public void RequestTimeTest()
        {
            /*Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .CreateLogger();*/

            HttpApiClient client = new HttpApiClient(BinanceDexEnvironment.TEST_NET);
            var time = client.Time();
            Assert.NotNull(time);
        }
    }
}
