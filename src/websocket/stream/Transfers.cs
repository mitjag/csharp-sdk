using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket.stream
{
    public class Transfers : IStreamData
    {
        /*
        {
    "e":"outboundTransferInfo",                                                // Event type
    "E":12893,                                                                 // Event height
    "H":"0434786487A1F4AE35D49FAE3C6F012A2AAF8DD59EC860DC7E77123B761DD91B",    // Transaction hash
    "f":"bnb1z220ps26qlwfgz5dew9hdxe8m5malre3qy6zr9",                          // From addr
    "t":
      [{
        "o":"bnb1xngdalruw8g23eqvpx9klmtttwvnlk2x4lfccu",                      // To addr
        "c":[{                                                                 // Coins
          "a":"BNB",                                                           // Asset
          "A":"100.00000000"                                                   // Amount
          }]
      }]
  }
         */

        public ETopic Topic { get { return ETopic.Transfers; } }
    }
}
