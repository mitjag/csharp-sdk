using NBitcoin;
using NBitcoin.DataEncoders;
using System;
using System.Collections.Generic;
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
            EcKey = new Key();
            Bech32Encoder bech32Encoder = new Bech32Encoder(Encoding.UTF8.GetBytes(Env.Hrp));
            Address = bech32Encoder.EncodeData(EcKey.PubKey.Hash.ToBytes());
        }
    }
}
