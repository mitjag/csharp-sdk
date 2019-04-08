using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class TransactionMetadata
    {
        public int Code { get; set; }
        public string Data { get; set; }
        public string Hash { get; set; }
        public string Log { get; set; }
        public bool Ok { get; set; }
    }
}
