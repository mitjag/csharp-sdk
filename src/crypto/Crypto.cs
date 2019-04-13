using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk
{
    public static class Crypto
    {

        public static String getPrivateKeyFromMnemonicCode(Wordlist wordlist)
        {
            /*byte[] seed = MnemonicCode.INSTANCE.toSeed(words, "");
            
            DeterministicKey key = HDKeyDerivation.createMasterPrivateKey(seed);

            List<ChildNumber> childNumbers = HDUtils.parsePath(HD_PATH);
            for (ChildNumber cn : childNumbers)
            {
                key = HDKeyDerivation.deriveChildKey(key, cn);
            }
            return key.getPrivateKeyAs();*/
            Mnemonic mnemonic = new Mnemonic(wordlist);
            return mnemonic.ToString();
        }
    }
}
