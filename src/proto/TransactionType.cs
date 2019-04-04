using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binance.dex.sdk.proto
{

    public enum ETransactionType
    {
        Send,
        NewOrder,
        CancelOrder,
        TokenFreeze,
        TokenUnfreeze,
        StdSignature,
        PubKey,
        StdTx,
        Vote
    }

    public static class TransactionType
    {
        public static byte[] GetTransactionType(ETransactionType eTransactionType)
        {
            switch (eTransactionType)
            {
                case ETransactionType.Send:
                    return StringToByteArray("2A2C87FA");
                case ETransactionType.NewOrder:
                    return StringToByteArray("CE6DC043");
                case ETransactionType.CancelOrder:
                    return StringToByteArray("166E681B");
                case ETransactionType.TokenFreeze:
                    return StringToByteArray("E774B32D");
                case ETransactionType.TokenUnfreeze:
                    return StringToByteArray("6515FF0D");
                case ETransactionType.StdSignature:
                    return new byte[0];
                case ETransactionType.PubKey:
                    return StringToByteArray("EB5AE987");
                case ETransactionType.StdTx:
                    return StringToByteArray("F0625DEE");
                case ETransactionType.Vote:
                    return StringToByteArray("A1CADD36");
                default:
                    return new byte[0];
            }
        }

        private static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}
