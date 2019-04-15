using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class Candlestick
    {

        /*
        close number  closing price
        closeTime long
        high    number the highest price
        low number  the lowest price
        numberOfTrades  integer
        open    number open price
        openTime    long time of open trade
        quoteAssetVolume    number
        volume  number
        */

        /*
[
  1499040000000,      // Open time
  "0.01634790",       // Open
  "0.80000000",       // High
  "0.01575800",       // Low
  "0.01577100",       // Close
  "148976.11427815",  // Volume
  1499644799999,      // Close time
  "2434.19055334",    // Quote asset volume
  308                // Number of trades
]
        */

        public List<object> Candlesticks { get; set; }
    }
}
