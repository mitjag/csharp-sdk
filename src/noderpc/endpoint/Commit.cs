using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    /*
        {
          "jsonrpc": "2.0",
          "id": "",
          "result": {
            "signed_header": {
              "header": {
                "version": {
                  "block": "10",
                  "app": "0"
                },
                "chain_id": "Binance-Chain-Nile",
                "height": "10779111",
                "time": "2019-04-26T07:58:03.743614951Z",
                "num_txs": "0",
                "total_txs": "8678314",
                "last_block_id": {
                  "hash": "0AD7D7DD5B45AAB9DD8C530F10F785912BE999C4027255C47424FA81377C0B03",
                  "parts": {
                    "total": "1",
                    "hash": "680FD2A9CDC19A35AAD6FC3F2C7069E2DA370AD558F3D421F474D34B0FF5B655"
                  }
                },
                "last_commit_hash": "42102AE96B53BB28CA5D26E3CCB0BDE0D8EA636B9AEEF65F6176C71F62DEAE43",
                "data_hash": "",
                "validators_hash": "80D9AB0FC10D18CA0E0832D5F4C063C5489EC1443DFB738252D038A82131B27A",
                "next_validators_hash": "80D9AB0FC10D18CA0E0832D5F4C063C5489EC1443DFB738252D038A82131B27A",
                "consensus_hash": "294D8FBD0B94B767A7EBA9840F299A3586DA7FE6B5DEAD3B7EECBA193C400F93",
                "app_hash": "8303ECF3FFBFCB51B92DC8FABEC9331606331648192B2FDFC9314D551C2133F5",
                "last_results_hash": "",
                "evidence_hash": "",
                "proposer_address": "06FD60078EB4C2356137DD50036597DB267CF616"
              },
              "commit": {
                "block_id": {
                  "hash": "989A3A075B6168A5B0F9B75F69BC71608E65D7A8A632F0D462AD311A646923ED",
                  "parts": {
                    "total": "1",
                    "hash": "DD1C1DE37792C983418627FE0C445A81831B9B64C780B923D3202B3247A003F7"
                  }
                },
                "precommits": [
                  {
                    "type": 2,
                    "height": "10779111",
                    "round": "0",
                    "block_id": {
                      "hash": "989A3A075B6168A5B0F9B75F69BC71608E65D7A8A632F0D462AD311A646923ED",
                      "parts": {
                        "total": "1",
                        "hash": "DD1C1DE37792C983418627FE0C445A81831B9B64C780B923D3202B3247A003F7"
                      }
                    },
                    "timestamp": "2019-04-26T07:58:04.261926071Z",
                    "validator_address": "06FD60078EB4C2356137DD50036597DB267CF616",
                    "validator_index": "0",
                    "signature": "Kl+kQM/jQcuPK26CgV+sSgiB78GzJbZuiiuwHizqN8rctIxYsWBIIYkCtz5y3y2P3UcqOO6yfLpAEnXXdTawAA=="
                  },
                  {
                    "type": 2,
                    "height": "10779111",
                    "round": "0",
                    "block_id": {
                      "hash": "989A3A075B6168A5B0F9B75F69BC71608E65D7A8A632F0D462AD311A646923ED",
                      "parts": {
                        "total": "1",
                        "hash": "DD1C1DE37792C983418627FE0C445A81831B9B64C780B923D3202B3247A003F7"
                      }
                    },
                    "timestamp": "2019-04-26T07:58:04.232122407Z",
                    "validator_address": "18E69CC672973992BB5F76D049A5B2C5DDF77436",
                    "validator_index": "1",
                    "signature": "PUL6GceBZUlsMT4v4vRRz0WW8cOCykWr48ILfu0PyIEnDJ9HU/6G6livT0OMwQVr11IFxuqLVoGMv+K4ao5DDw=="
                  },
                  {
                    "type": 2,
                    "height": "10779111",
                    "round": "0",
                    "block_id": {
                      "hash": "989A3A075B6168A5B0F9B75F69BC71608E65D7A8A632F0D462AD311A646923ED",
                      "parts": {
                        "total": "1",
                        "hash": "DD1C1DE37792C983418627FE0C445A81831B9B64C780B923D3202B3247A003F7"
                      }
                    },
                    "timestamp": "2019-04-26T07:58:04.228605713Z",
                    "validator_address": "344C39BB8F4512D6CAB1F6AAFAC1811EF9D8AFDF",
                    "validator_index": "2",
                    "signature": "I7ZX5E3bmFi1Tx0d4MavQZgsYu0hEfgqqTpu7ktA3rFWPTISnwRwQlSfSPL7KCFk13Q5MB6yiXOk21U9so68DQ=="
                  },
                  {
                    "type": 2,
                    "height": "10779111",
                    "round": "0",
                    "block_id": {
                      "hash": "989A3A075B6168A5B0F9B75F69BC71608E65D7A8A632F0D462AD311A646923ED",
                      "parts": {
                        "total": "1",
                        "hash": "DD1C1DE37792C983418627FE0C445A81831B9B64C780B923D3202B3247A003F7"
                      }
                    },
                    "timestamp": "2019-04-26T07:58:04.258856808Z",
                    "validator_address": "37EF19AF29679B368D2B9E9DE3F8769B35786676",
                    "validator_index": "3",
                    "signature": "RhLd1kPh/nppBYws8Kg26AUNIT0oTpW8dYLjknF6oURlQbMTRnR5CrW+QLlRWAqxwVHZYXx/w8NYKwCtFutvDQ=="
                  },
                  {
                    "type": 2,
                    "height": "10779111",
                    "round": "0",
                    "block_id": {
                      "hash": "989A3A075B6168A5B0F9B75F69BC71608E65D7A8A632F0D462AD311A646923ED",
                      "parts": {
                        "total": "1",
                        "hash": "DD1C1DE37792C983418627FE0C445A81831B9B64C780B923D3202B3247A003F7"
                      }
                    },
                    "timestamp": "2019-04-26T07:58:04.15797117Z",
                    "validator_address": "62633D9DB7ED78E951F79913FDC8231AA77EC12B",
                    "validator_index": "4",
                    "signature": "M68J2PpUH1CMuKy7JNu760OKZ5Yk780rCpMpM8Xq1eo4WtbQkem9xpChcv7gznDrRQtzW8MgwzTGOfwOYhI0CQ=="
                  },
                  {
                    "type": 2,
                    "height": "10779111",
                    "round": "0",
                    "block_id": {
                      "hash": "989A3A075B6168A5B0F9B75F69BC71608E65D7A8A632F0D462AD311A646923ED",
                      "parts": {
                        "total": "1",
                        "hash": "DD1C1DE37792C983418627FE0C445A81831B9B64C780B923D3202B3247A003F7"
                      }
                    },
                    "timestamp": "2019-04-26T07:58:04.161066892Z",
                    "validator_address": "7B343E041CA130000A8BC00C35152BD7E7740037",
                    "validator_index": "5",
                    "signature": "I3IIiuWvuDTfZJ13GBn4T0Kn+0bNm83LtXjnP4+ZDFAwzJjNPY0rrOyc0vH0XMIoGRBT8dBkDhIAp8sZGts4BA=="
                  },
                  {
                    "type": 2,
                    "height": "10779111",
                    "round": "0",
                    "block_id": {
                      "hash": "989A3A075B6168A5B0F9B75F69BC71608E65D7A8A632F0D462AD311A646923ED",
                      "parts": {
                        "total": "1",
                        "hash": "DD1C1DE37792C983418627FE0C445A81831B9B64C780B923D3202B3247A003F7"
                      }
                    },
                    "timestamp": "2019-04-26T07:58:04.227937653Z",
                    "validator_address": "91844D296BD8E591448EFC65FD6AD51A888D58FA",
                    "validator_index": "6",
                    "signature": "2buIrjd5uskQrXld9vLLWzYvO0lAajlojyST6C4cA0IRAmL74dWCE8rjhD8QWJ/WKfUX50MCgdklDnV6BZ/wAA=="
                  },
                  {
                    "type": 2,
                    "height": "10779111",
                    "round": "0",
                    "block_id": {
                      "hash": "989A3A075B6168A5B0F9B75F69BC71608E65D7A8A632F0D462AD311A646923ED",
                      "parts": {
                        "total": "1",
                        "hash": "DD1C1DE37792C983418627FE0C445A81831B9B64C780B923D3202B3247A003F7"
                      }
                    },
                    "timestamp": "2019-04-26T07:58:04.227522546Z",
                    "validator_address": "B3727172CE6473BC780298A2D66C12F1A14F5B2A",
                    "validator_index": "7",
                    "signature": "t6bJZaatSjgTqsiNWJla/nWUpgRYXqi1cDa/TLXnRxEVfg/J+JJ2KUd3E4orHdcG1iVK4MT7GRf74ee0wzksDw=="
                  },
                  {
                    "type": 2,
                    "height": "10779111",
                    "round": "0",
                    "block_id": {
                      "hash": "989A3A075B6168A5B0F9B75F69BC71608E65D7A8A632F0D462AD311A646923ED",
                      "parts": {
                        "total": "1",
                        "hash": "DD1C1DE37792C983418627FE0C445A81831B9B64C780B923D3202B3247A003F7"
                      }
                    },
                    "timestamp": "2019-04-26T07:58:04.25961766Z",
                    "validator_address": "B6F20C7FAA2B2F6F24518FA02B71CB5F4A09FBA3",
                    "validator_index": "8",
                    "signature": "tniWuqAhkllmQNtJOzgk7mI15suFVEr1ngAb5UKeI6JPzQHYM/BNQmDD8TGGxZvNVKdaGSXyVEoFxPWHdQdMDA=="
                  },
                  {
                    "type": 2,
                    "height": "10779111",
                    "round": "0",
                    "block_id": {
                      "hash": "989A3A075B6168A5B0F9B75F69BC71608E65D7A8A632F0D462AD311A646923ED",
                      "parts": {
                        "total": "1",
                        "hash": "DD1C1DE37792C983418627FE0C445A81831B9B64C780B923D3202B3247A003F7"
                      }
                    },
                    "timestamp": "2019-04-26T07:58:04.159001321Z",
                    "validator_address": "E0DD72609CC106210D1AA13936CB67B93A0AEE21",
                    "validator_index": "9",
                    "signature": "ecKyM5/b8D/Lxdq9i+IeDs6mGC0xvyidLggb6Ukd04HNB6eXQ7A4YXkkEafEE3FnqsBk1Wohde/UOTJRoOCBBQ=="
                  },
                  {
                    "type": 2,
                    "height": "10779111",
                    "round": "0",
                    "block_id": {
                      "hash": "989A3A075B6168A5B0F9B75F69BC71608E65D7A8A632F0D462AD311A646923ED",
                      "parts": {
                        "total": "1",
                        "hash": "DD1C1DE37792C983418627FE0C445A81831B9B64C780B923D3202B3247A003F7"
                      }
                    },
                    "timestamp": "2019-04-26T07:58:04.160623835Z",
                    "validator_address": "FC3108DC3814888F4187452182BC1BAF83B71BC9",
                    "validator_index": "10",
                    "signature": "+HT8roBnvoZhRni4AErXI4diclG7T9rm9mR71aVr9tECckyJoGjspNnGN/yn6qgP3gA46c8lPN+OipomLO1jBg=="
                  }
                ]
              }
            },
            "canonical": true
          }
        }
    */

    public class CommitSignedHeader
    {
        [JsonProperty("header")]
        public BlockHeader Header { get; set; }

        [JsonProperty("commit")]
        public BlockCommit Commit { get; set; }
    }

    public class ResultCommit : IEndpointResponse
    {
        [JsonProperty("signed_header")]
        public CommitSignedHeader SignedHeader { get; set; }

        [JsonProperty("canonical")]
        public bool Canonical { get; set; }
    }
}
