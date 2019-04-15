using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket.stream
{
    public class MarketDiff : IStreamData
    {
        /*
         {
        "e": "depthUpdate",   // Event type
        "E": 123456789,       // Event time
        "s": "BNB_BTC",       // Symbol
        "b": [                // Bids to be updated
            [
            "0.0024",         // Price level to be updated
            "10"              // Quantity
            ]
        ],
        "a": [                // Asks to be updated
            [
            "0.0026",         // Price level to be updated
            "100"             // Quantity
            ]
        ]
    }
         */

        public ETopic Topic { get { return ETopic.MarketDiff; } }
    }
}
