using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.broadcast
{
    public class CancelOrder
    {
        public String Symbol { get; set; }

        //[JsonProperty("refid")]
        public String RefId { get; set; }
    }
}
