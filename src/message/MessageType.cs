using binance.dex.sdk.crypto;
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
                    return EncodeUtils.StringToByteArray("2A2C87FA");
                case EMessageType.NewOrder:
                    return EncodeUtils.StringToByteArray("CE6DC043");
                case EMessageType.CancelOrder:
                    return EncodeUtils.StringToByteArray("166E681B");
                case EMessageType.TokenFreeze:
                    return EncodeUtils.StringToByteArray("E774B32D");
                case EMessageType.TokenUnfreeze:
                    return EncodeUtils.StringToByteArray("6515FF0D");
                case EMessageType.StdSignature:
                    return new byte[0];
                case EMessageType.PubKey:
                    return EncodeUtils.StringToByteArray("EB5AE987");
                case EMessageType.StdTx:
                    return EncodeUtils.StringToByteArray("F0625DEE");
                case EMessageType.Vote:
                    return EncodeUtils.StringToByteArray("A1CADD36");
                default:
                    return new byte[0];
            }
        }
    }
}
