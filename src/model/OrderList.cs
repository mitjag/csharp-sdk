using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class OrderList
    {
        /// <summary>
        /// order[Order] list of orders
        /// </summary>
        [JsonProperty("order")]
        public List<Order> Orders { get; set; }

        /// <summary>
        /// total long
        /// </summary>
        [JsonProperty("total")]
        public long Total { get; set; }
    }
}
