using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.broadcast
{
    public class TransactionOption
    {
        public const long BINANCE_DEX_API_CLIENT_CSHARP_SOURCE = 4;

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
                    Source = BINANCE_DEX_API_CLIENT_CSHARP_SOURCE,
                    Data = null
                };
            }
        }
    }
}
