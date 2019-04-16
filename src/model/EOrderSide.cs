using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public enum EOrderSide
    {
        Buy, Sell
    }

    public class OrderSide
    {
        public const long Buy = 1;
        public const long Sell = 2;

        public static long ToOrderSide(EOrderSide orderSide)
        {
            switch (orderSide)
            {
                case EOrderSide.Buy:
                    return Buy;
                case EOrderSide.Sell:
                    return Sell;
                default:
                    throw new BinanceDexException($"Unhandled orderSide: {orderSide}");
            }
        }
    }
}
