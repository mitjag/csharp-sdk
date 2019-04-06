using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binance.dex.sdk.message
{
    public enum EMessageType
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

    public static class MessageType
    {
        public static byte[] GetTransactionType(EMessageType eTransactionType)
        {
            switch (eTransactionType)
            {
                case EMessageType.Send:
                    return StringToByteArray("2A2C87FA");
                case EMessageType.NewOrder:
                    return StringToByteArray("CE6DC043");
                case EMessageType.CancelOrder:
                    return StringToByteArray("166E681B");
                case EMessageType.TokenFreeze:
                    return StringToByteArray("E774B32D");
                case EMessageType.TokenUnfreeze:
                    return StringToByteArray("6515FF0D");
                case EMessageType.StdSignature:
                    return new byte[0];
                case EMessageType.PubKey:
                    return StringToByteArray("EB5AE987");
                case EMessageType.StdTx:
                    return StringToByteArray("F0625DEE");
                case EMessageType.Vote:
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
