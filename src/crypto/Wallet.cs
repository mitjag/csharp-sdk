using binance.dex.sdk.message;
using NBitcoin;
using NBitcoin.DataEncoders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;

namespace binance.dex.sdk.crypto
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
        public string ChainId { get; set; }

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
            byte[] pubKey = EcKey.PubKey.ToBytes();
            byte[] pubKeyPrefix = MessageType.GetTransactionType(EMessageType.PubKey);
            PubKeyForSign = new byte[pubKey.Length + pubKeyPrefix.Length + 1];
            pubKeyPrefix.CopyTo(PubKeyForSign, 0);
            PubKeyForSign[pubKeyPrefix.Length] = 33;
            pubKey.CopyTo(PubKeyForSign, pubKeyPrefix.Length + 1);
        }

        public byte[] DecodeAddress(string address)
        {
            Bech32Decoder bech32Decoder = new Bech32Decoder(Env.Hrp);
            return bech32Decoder.DecodeData(address);
        }
    }
}
