using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.broadcast
{
    public class Output
    {
        public string Address { get; set; }

        public List<OutputToken> Tokens { get; set; }
    }
}
