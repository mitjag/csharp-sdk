using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class TxPage
    {
        /// <summary>
        ///  tx[Tx]
        /// </summary>
        [JsonProperty("tx")]
        public List<Tx> Tx { get; set; }

        /// <summary>
        /// total long total sum of transactions
        /// </summary>
        [JsonProperty("total")]
        public long Total { get; set; }
    }
}
