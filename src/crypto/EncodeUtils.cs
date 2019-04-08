using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.crypto
{
    public static class EncodeUtils
    {
        public static byte[] AminoWrap(byte[] raw, byte[] typePrefix, bool isPrefixLength)
        {
            int totalLen = raw.Length + typePrefix.Length;
            if (isPrefixLength)
            {
                totalLen += CodedOutputStream.ComputeUInt64Size((ulong)totalLen);
            }

            byte[] msg = new byte[totalLen];
            CodedOutputStream cos = new CodedOutputStream(msg);
            if (isPrefixLength)
            {
                cos.WriteUInt64((ulong)(raw.Length + typePrefix.Length));
            }
            cos.WriteBytes(ByteString.CopyFrom(typePrefix));
            cos.WriteBytes(ByteString.CopyFrom(raw));
            cos.Flush();
            return msg;
        }
    }
}
