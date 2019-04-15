using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket.stream
{
    public enum EKLineInterval
    {
        Minute1, Minute3, Minute5, Minute15, Minute30, Hour1, Hour2, Hour4, Hour6, Hour8, Hour12, Day1, Day3, Week1, Month1
    }

    public class KLineInterval
    {
        private const string Minute1 = "1m";
        private const string Minute3 = "3m";
        private const string Minute5 = "5m";
        private const string Minute15 = "15m";
        private const string Minute30 = "30m";
        private const string Hour1 = "1h";
        private const string Hour2 = "2h";
        private const string Hour4 = "4h";
        private const string Hour6 = "6h";
        private const string Hour8 = "8h";
        private const string Hour12 = "12h";
        private const string Day1 = "1d";
        private const string Day3 = "3d";
        private const string Week1 = "1w";
        private const string Month1 = "1M";

        public static string ToKLineInterval(EKLineInterval kLineInterval)
        {
            switch (kLineInterval)
            {
                case EKLineInterval.Minute1:
                    return Minute1;
                case EKLineInterval.Minute3:
                    return Minute3;
                case EKLineInterval.Minute5:
                    return Minute5;
                case EKLineInterval.Minute15:
                    return Minute15;
                case EKLineInterval.Minute30:
                    return Minute30;
                case EKLineInterval.Hour1:
                    return Hour1;
                case EKLineInterval.Hour2:
                    return Hour2;
                case EKLineInterval.Hour4:
                    return Hour4;
                case EKLineInterval.Hour6:
                    return Hour6;
                case EKLineInterval.Hour8:
                    return Hour8;
                case EKLineInterval.Hour12:
                    return Hour12;
                case EKLineInterval.Day1:
                    return Day1;
                case EKLineInterval.Day3:
                    return Day3;
                case EKLineInterval.Week1:
                    return Week1;
                case EKLineInterval.Month1:
                    return Month1;
                default:
                    throw new WebSocketException($"Unhandled kLineInterval: {kLineInterval}");
            }
        }
    }
}
