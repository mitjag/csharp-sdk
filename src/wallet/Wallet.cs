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

        public Wallet(string privateKey, BinanceDexEnvironmentData env)
        {
            PrivateKey = privateKey;
            Env = env;
            BigInteger privateKeyBigInteger = BigInteger.Parse("0" + PrivateKey, NumberStyles.HexNumber);

            EcKey = new Key(privateKeyBigInteger.ToByteArray());
            
            Bech32Encoder bech32Encoder = new Bech32Encoder(Encoding.UTF8.GetBytes(Env.Hrp));
            Address = bech32Encoder.EncodeData(EcKey.PubKey.Hash.ToBytes());
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             //.Reverse()
                             .ToArray();
        }
    }
}
