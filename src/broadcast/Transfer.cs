using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.broadcast
{
    public class Transfer
    {
        public string FromAddress { get; set; }

        public string ToAddress { get; set; }

        public string Coin { get; set; }

        public string Amount { get; set; }
    }
}
