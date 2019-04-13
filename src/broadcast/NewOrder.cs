using binance.dex.sdk.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.broadcast
{
    public class NewOrder
    {
        public string Symbol { get; set; }

        public EOrderType OrderType { get; set; }

        public EOrderSide Side { get; set; }

        public string Price { get; set; }

        public string Quantity { get; set; }

        public ETimeInForce TimeInForce { get; set; }
    }
}
