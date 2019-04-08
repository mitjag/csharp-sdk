using binance.dex.sdk.message;
using NBitcoin;
using NBitcoin.Crypto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace binance.dex.sdk.crypto
{
    public static class Signature
    {
        public static byte[] Sign(SignData signData, Key ecKey)
        {
            string json = JsonConvert.SerializeObject(signData);
            byte[] bytes = Encoding.UTF8.GetBytes(json);
            return Sign(bytes, ecKey);
        }

        public static byte[] Sign(byte[] msg, Key ecKey)
        {
            byte[] hash;
            using (SHA256 sha256 = SHA256.Create())
            {
                hash = sha256.ComputeHash(msg);
            }
            uint256 uint256le = new uint256(hash, true);

            ECDSASignature signature = ecKey.Sign(uint256le, false);

            byte[] signatureBytes = new byte[64];
            signature.R.ToByteArrayUnsigned().CopyTo(signatureBytes, 0);
            signature.S.ToByteArrayUnsigned().CopyTo(signatureBytes, 32);
            return signatureBytes;
        }
    }
}
