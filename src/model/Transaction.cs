using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class Transaction
    {
        /// <summary>
        /// hash string Hash of transaction
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// log string Log of transaction
        /// </summary>
        [JsonProperty("log")]
        public string Log { get; set; }

        /// <summary>
        /// data string Data of transaction
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("ok")]
        public bool Ok { get; set; }

        /// <summary>
        /// tx object Detail of transaction, like transaction type, messages and signature
        /// </summary>
        [JsonProperty("tx")]
        public string Tx { get; set; }
        /*
                {
            "type": "auth/StdTx", // fixed, type of transaction
            "value": {            // fixed, detail of the transaction
                        "data": null,     // fixed, data of the transaction
                "memo": "",       // fixed, memo
                "msg": [          // fixed, msgs of the transaction
                    {
                        "type": "cosmos-sdk/Send",  // vary with msg type
                        "value": {                  // value content vary with mst type
                            "inputs": [
                                {
                                    "address": "bnb1vt4zwu5hy7tyryktud6mpcu8h2ehh6xw66gzwp",
                                    "coins": [
                                        {
                                            "amount": "100000000000000",
                                            "denom": "BNB"
                                        }
                                    ]
                                }
                            ],
                            "outputs": [
                                {
                                    "address": "bnb1kg8mh20tndur9d9rry4wjunhpfzcud30qzf0qv",
                                    "coins": [
                                        {
                                            "amount": "100000000000000",
                                            "denom": "BNB"
                                        }
                                    ]
                                }
                            ]
                        }
                    }
                ],
                "signatures": [ // fixed, signatures of the transaction
                    {
                        "account_number": "0",
                        "pub_key": {
                            "type": "tendermint/PubKeySecp256k1",
                            "value": "AoWY3eWBOnnvLPTz4RsUlX1pWCkLLPewu1vAAoTEzxzR"
                        },
                        "sequence": "1",
                        "signature": "6O2TQAgleFNPw4zIWBLaNvOf5dR7DHNSr2DwAPeFK6lokRqZd2KR2BD+WlmaWj4LdLo5N+utN1JtY41E91N0uw=="
                    }
                ],
                "source": "0"  // fixed, source of the transaction
            }
        }*/
    }
}
