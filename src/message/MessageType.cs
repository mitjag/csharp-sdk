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
                    return EncodeUtils.HexToByteArray("2A2C87FA");
                case EMessageType.NewOrder:
                    return EncodeUtils.HexToByteArray("CE6DC043");
                case EMessageType.CancelOrder:
                    return EncodeUtils.HexToByteArray("166E681B");
                case EMessageType.TokenFreeze:
                    return EncodeUtils.HexToByteArray("E774B32D");
                case EMessageType.TokenUnfreeze:
                    return EncodeUtils.HexToByteArray("6515FF0D");
                case EMessageType.StdSignature:
                    return new byte[0];
                case EMessageType.PubKey:
                    return EncodeUtils.HexToByteArray("EB5AE987");
                case EMessageType.StdTx:
                    return EncodeUtils.HexToByteArray("F0625DEE");
                case EMessageType.Vote:
                    return EncodeUtils.HexToByteArray("A1CADD36");
                default:
                    return new byte[0];
            }
        }
    }
}
