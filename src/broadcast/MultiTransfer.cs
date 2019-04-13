using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.broadcast
{
    public class MultiTransfer
    {
        public String fromAddress { get; set; }

        public List<Output> outputs { get; set; }
    }
}
