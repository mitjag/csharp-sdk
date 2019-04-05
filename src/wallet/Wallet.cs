using binance.dex.sdk.proto;
using NBitcoin;
using NBitcoin.DataEncoders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;

namespace binance.dex.sdk.wallet
{
    public class Wallet
    {
        public string PrivateKey { get; set; }
        public string Address { get; set; }
        public Key EcKey { get; set; }
        public byte[] AddressBytes { get; set; }
        public byte[] PubKeyForSign { get; set; }
        public int AccountNumber { get; set; }
        public long? Sequence { get; set; }
        public BinanceDexEnvironmentData Env { get; set; }

        const string pbase32 = "abcdefghijklmnopqrstuvwxyz234567";

        public Wallet(string privateKey, BinanceDexEnvironmentData env)
        {
            PrivateKey = privateKey;
            Env = env;
            BigInteger privateKeyBigInteger = BigInteger.Parse("0" + PrivateKey, NumberStyles.HexNumber);
            EcKey = new Key(privateKeyBigInteger.ToByteArray(true, true));
            Bech32Encoder bech32Encoder = Encoders.Bech32(Env.Hrp);
            AddressBytes = EcKey.PubKey.Hash.ToBytes();
            string b32 = Encoders.Base32.EncodeData(AddressBytes);
            byte[] address32 = new byte[b32.Length];
            for (int i = 0; i < b32.Length; i++)
            {
                address32[i] = (byte) pbase32.IndexOf(b32[i]);
            }
            Address = bech32Encoder.EncodeData(address32);
            //byte[] test = { 7, 15, 7, 26, 0, 24, 5, 4, 6, 11, 22, 20, 28, 9, 13, 13, 1, 31, 25, 7, 28, 1, 9, 15, 22, 17, 15, 30, 10, 12, 12, 29 };
            //string testAddress = bech32Encoder.EncodeData(test);

            byte[] pubKey = EcKey.PubKey.ToBytes();
            byte[] pubKeyPrefix = TransactionType.GetTransactionType(ETransactionType.PubKey);
            PubKeyForSign = new byte[pubKey.Length + pubKeyPrefix.Length + 1];
            pubKeyPrefix.CopyTo(PubKeyForSign, 0);
            PubKeyForSign[pubKeyPrefix.Length] = 33;
            pubKey.CopyTo(PubKeyForSign, pubKeyPrefix.Length + 1);
        }
    }
}
