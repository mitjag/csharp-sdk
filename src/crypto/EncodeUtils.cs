using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
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
            //cos.WriteBytes(ByteString.CopyFrom(typePrefix));
            //cos.WriteBytes(ByteString.CopyFrom(raw));
            for (int i = 0; i < typePrefix.Length; i++)
            {
                cos.WriteRawTag(typePrefix[i]);
            }
            for (int i = 0; i < raw.Length; i++)
            {
                cos.WriteRawTag(raw[i]);
            }
            cos.Flush();
            return msg;
        }

        public static byte[] HexToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        public static string ByteArrayToHex(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", "");
            /*StringBuilder sb = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
            {
                sb.AppendFormat("{0:x2}", b)
            }
            return sb.ToString();*/
        }
    }
}
