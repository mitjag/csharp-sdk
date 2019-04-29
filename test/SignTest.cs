using binance.dex.sdk.message;
using binance.dex.sdk.crypto;
using NBitcoin;
using NBitcoin.Crypto;
using NBitcoin.DataEncoders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace binance.dex.sdk.test
{
    public class SignTest
    {
        [Fact]
        public void SignDataTest()
        {
            InputOutput input = new InputOutput
            {
                Address = "tbnb18086qc9yxtk5ufddple8upf0k3072vvagpm2ml",
                Coins = new List<Token> {
                    new Token
                    {
                        Denom = "PND-943",
                        Amount = 100000000
                    }
                }
            };

            InputOutput output = new InputOutput
            {
                Address = "tbnb18086qc9yxtk5ufddple8upf0k3072vvagpm2ml",
                Coins = new List<Token> {
                    new Token
                    {
                        Denom = "PND-943",
                        Amount = 100000000
                    }
                }
            };

            TransferMessage transferMessage = new TransferMessage
            {
                Inputs = new List<InputOutput> { input },
                Outputs = new List<InputOutput> { output }
            };

            SignData signData = new SignData
            {
                ChainId = "Binance-Chain-Nile",
                AccountNumber = "667519",
                Sequence = "0",
                Memo = "",
                Msgs = new TransferMessage[] { transferMessage },
                Source = "3",
                Data = null
            };

            //JsonSerializer serializer = new JsonSerializer();
            string json = JsonConvert.SerializeObject(signData);
            // bytes = [123, 34, 97, 99, 99, 111, 117, 110, 116, 95, 110, 117, 109, 98, 101, 114, 34, 58, 34, 54, 54, 55, 53, 49, 57, 34, 44, 34, 99, 104, 97, 105, 110, 95, 105, 100, 34, 58, 34, 66, 105, 110, 97, 110, 99, 101, 45, 67, 104, 97, 105, 110, 45, 78, 105, 108, 101, 34, 44, 34, 100, 97, 116, 97, 34, 58, 110, 117, 108, 108, 44, 34, 109, 101, 109, 111, 34, 58, 34, 34, 44, 34, 109, 115, 103, 115, 34, 58, 91, 123, 34, 105, 110, 112, 117, 116, 115, 34, 58, 91, 123, 34, 97, 100, 100, 114, 101, 115, 115, 34, 58, 34, 116, 98, 110, 98, 49, 56, 48, 56, 54, 113, 99, 57, 121, 120, 116, 107, 53, 117, 102, 100, 100, 112, 108, 101, 56, 117, 112, 102, 48, 107, 51, 48, 55, 50, 118, 118, 97, 103, 112, 109, 50, 109, 108, 34, 44, 34, 99, 111, 105, 110, 115, 34, 58, 91, 123, 34, 97, 109, 111, 117, 110, 116, 34, 58, 49, 48, 48, 48, 48, 48, 48, 48, 48, 44, 34, 100, 101, 110, 111, 109, 34, 58, 34, 80, 78, 68, 45, 57, 52, 51, 34, 125, 93, 125, 93, 44, 34, 111, 117, 116, 112, 117, 116, 115, 34, 58, 91, 123, 34, 97, 100, 100, 114, 101, 115, 115, 34, 58, 34, 116, 98, 110, 98, 49, 56, 48, 56, 54, 113, 99, 57, 121, 120, 116, 107, 53, 117, 102, 100, 100, 112, 108, 101, 56, 117, 112, 102, 48, 107, 51, 48, 55, 50, 118, 118, 97, 103, 112, 109, 50, 109, 108, 34, 44, 34, 99, 111, 105, 110, 115, 34, 58, 91, 123, 34, 97, 109, 111, 117, 110, 116, 34, 58, 49, 48, 48, 48, 48, 48, 48, 48, 48, 44, 34, 100, 101, 110, 111, 109, 34, 58, 34, 80, 78, 68, 45, 57, 52, 51, 34, 125, 93, 125, 93, 125, 93, 44, 34, 115, 101, 113, 117, 101, 110, 99, 101, 34, 58, 34, 48, 34, 44, 34, 115, 111, 117, 114, 99, 101, 34, 58, 34, 51, 34, 125]
            byte[] bytes = Encoding.UTF8.GetBytes(json);
            byte[] hash;
            using (SHA256 sha256 = SHA256.Create())
            {
                // hash = [-124, 96, -11, -122, -27, -7, 103, -38, -29, 0, -34, 45, 98, -83, 32, 16, -11, 108, -8, -88, -66, -80, 106, 14, -13, 34, -115, 99, -94, -124, -101, -117]
                hash = sha256.ComputeHash(bytes);
            }
            Wallet wallet = Wallet.FromPrivateKey("f0e87ed55fa3d86f62b38b405cbb5f732764a7d5bc690da45a32aa3f2fc81a36", BinanceDexEnvironment.TEST_NET);
            //string resultB = wallet.EcKey.SignMessage(bytes);
            //string resultS = wallet.EcKey.SignMessage(json);

            uint256 hash256 = Hashes.Hash256(bytes);
            uint256 uint256 = new uint256(hash, false);
            uint256 uint256le = new uint256(hash, true);
            //uint256 uint256 = new uint256("8460f586e5f967dae300de2d62ad2010f56cf8a8beb06a0ef3228d63a2849b8b");

            // message for GenerateSignature [-124, 96, -11, -122, -27, -7, 103, -38, -29, 0, -34, 45, 98, -83, 32, 16, -11, 108, -8, -88, -66, -80, 106, 14, -13, 34, -115, 99, -94, -124, -101, -117]
            ECDSASignature signature = wallet.EcKey.Sign(uint256le, false);

            byte[] signatureBytes = new byte[64];
            signature.R.ToByteArrayUnsigned().CopyTo(signatureBytes, 0);
            signature.S.ToByteArrayUnsigned().CopyTo(signatureBytes, 32);
            // r = 61420091277463284201584464261002339752469911249959494312431854777400008021097
            // s = 9337502753576151745268672761590576963567913315001541648793269425462248583710
            // signature result = [-121, -54, -118, 43, 107, -25, 50, -112, -101, 34, -63, -121, -111, -90, 109, -72, -95, -42, 55, -87, -108, -42, -21, -99, -2, -74, 13, -106, 99, -34, -108, 105, 20, -92, -42, -38, 116, -51, 15, 44, -17, -29, -119, -53, -119, -51, 58, -48, -38, -92, 39, -99, -64, 119, -81, 112, -97, -103, 112, -91, -71, -119, -78, 30]

            //byte[] resultBytes = Encoders.Base64.DecodeData(resultB);
        }
    }
}
