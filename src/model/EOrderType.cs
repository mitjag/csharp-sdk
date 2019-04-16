using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public enum EOrderType
    {
        Limit
    }

    public class OrderType
    {
        public const long Limit = 2;

        public static long ToOrderType(EOrderType orderType)
        {
            switch (orderType)
            {
                case EOrderType.Limit:
                    return Limit;
                default:
                    throw new BinanceDexException($"Unhandled orderType: {orderType}");
            }
        }
    }
}
