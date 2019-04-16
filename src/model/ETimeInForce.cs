using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public enum ETimeInForce
    {
        GTE, IOC
    }

    public class TimeInForce
    {
        public const long GTE = 1;
        public const long IOC = 3;

        public static long ToTimeInForce(ETimeInForce timeInForce)
        {
            switch (timeInForce)
            {
                case ETimeInForce.GTE:
                    return GTE;
                case ETimeInForce.IOC:
                    return IOC;
                default:
                    throw new BinanceDexException($"Unhandled timeInForce: {timeInForce}");
            }
        }
    }
}
