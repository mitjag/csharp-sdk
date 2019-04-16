using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk
{
    public class BinanceDexException : Exception
    {
        public BinanceDexException(string message) : base(message)
        {
        }
    }
}
