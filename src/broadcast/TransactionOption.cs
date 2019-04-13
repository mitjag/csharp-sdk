using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.broadcast
{
    public class TransactionOption
    {
        public string Memo { get; set; }
        public long Source { get; set; }
        public byte[] Data { get; set; }

        public static TransactionOption DefaultInstace
        {
            get
            {
                return new TransactionOption
                {
                    Memo = "",
                    Source = 3,
                    Data = null
                };
            }
        }
    }
}
