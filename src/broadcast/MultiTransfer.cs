using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.broadcast
{
    public class MultiTransfer
    {
        public String FromAddress { get; set; }

        public List<Output> Outputs { get; set; }
    }
}
