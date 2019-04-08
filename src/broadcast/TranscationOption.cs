using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.broadcast
{
    public class TranscationOption
    {
        public string Memo { get; set; }
        public long Source { get; set; }
        public byte[] Data { get; set; }

        public static TranscationOption DefaultInstace()
        {
            return new TranscationOption
            {
                Memo = "",
                Source = 3,
                Data = null
            };
        }
    }
}
