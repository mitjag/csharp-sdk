using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.message
{
    //@JsonIgnoreProperties(ignoreUnknown = true)
    //@JsonPropertyOrder(alphabetic = true)
    public class NewOrderMessage : ITransactionMessage
    {
        public String Id { get; set; }
        //@JsonProperty("ordertype")
        //public OrderType OrderType { get; set; }
        public long Price { get; set; }
        public long Quantity { get; set; }
        public String Sender { get; set; }
        //public OrderSide Side { get; set; }
        public String Symbol { get; set; }
        //@JsonProperty("timeinforce")
        //public TimeInForce TimeInForce { get; set; }
    }
}
