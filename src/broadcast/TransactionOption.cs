using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.broadcast
{
    public class TransactionOption
    {
        /// <summary>
        /// From Java SDK: BINANCE_DEX_API_CLIENT_JAVA_SOURCE = 3L
        /// We are increamenting the source value by 1 so we use source = 4
        /// (Binance team has to assign this value)
        /// </summary>
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
