using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    /*
     * Return Parameters return round states
     * 
        type ResultConsensusState struct {
            RoundState json.RawMessage `
        } 
    */

    /*
        {
          "jsonrpc": "2.0",
          "id": "",
          "result": {
            "round_state": {
              "height": "9773742",
              "round": "0",
              "step": 6,
              "start_time": "2019-04-21T14:11:15.227385202Z",
              "commit_time": "2019-04-21T14:11:14.227385202Z",
              "validators": {
                "validators": [
                  {
                    "address": "06FD60078EB4C2356137DD50036597DB267CF616",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "4Xy+nCDNz9+HazsSl40yZKAH/KqnHEzbcB2evAMj9E8="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-100000000000"
                  },
                  {
                    "address": "18E69CC672973992BB5F76D049A5B2C5DDF77436",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "GE57ED00xBAD+bhk1fjBrdqb0ENrJTuzyES8c5wed8k="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-100000000000"
                  },
                  {
                    "address": "344C39BB8F4512D6CAB1F6AAFAC1811EF9D8AFDF",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "TUIK6oQ+kqDP5p2JaW3/aCd2n5y1KiSa9TfOib8qS3Q="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-100000000000"
                  },
                  {
                    "address": "37EF19AF29679B368D2B9E9DE3F8769B35786676",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "vQPen4qynigACU4VP6xvaWz6USU2ycL4BNyywsTkrtY="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-100000000000"
                  },
                  {
                    "address": "62633D9DB7ED78E951F79913FDC8231AA77EC12B",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "j0p0oHNRiV3fNzBXuY+ubfryzSHzegY+GWAQeP5HDVM="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-100000000000"
                  },
                  {
                    "address": "7B343E041CA130000A8BC00C35152BD7E7740037",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "Sl1HU+t5+S6A7+It96yk9mak9Ev4HFNsSgnUucW2VLU="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-100000000000"
                  },
                  {
                    "address": "91844D296BD8E591448EFC65FD6AD51A888D58FA",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "yA6avvf/Q5wQxo/o8TA97d/FJ3GMOzfYumgHRG48gno="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-100000000000"
                  },
                  {
                    "address": "B3727172CE6473BC780298A2D66C12F1A14F5B2A",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "kUKvzGkbfMBdJsewvgyLRkGClBcXMOB584T94vpQuvw="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-100000000000"
                  },
                  {
                    "address": "B6F20C7FAA2B2F6F24518FA02B71CB5F4A09FBA3",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "SbKI5Ou7OigcLVRvwwJT1brwiZO25dKV+3h6WzFKKY4="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-100000000000"
                  },
                  {
                    "address": "E0DD72609CC106210D1AA13936CB67B93A0AEE21",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "BCJDOWiPAS5kneSOJBiACS6qj2qg9PFL/Pngx2kXwLY="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-100000000000"
                  },
                  {
                    "address": "FC3108DC3814888F4187452182BC1BAF83B71BC9",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "QDSzfO2ooL8Tsauu7nqPk4NUIJmlVNIZuT0M5p45cOg="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "1000000000000"
                  }
                ],
                "proposer": {
                  "address": "E0DD72609CC106210D1AA13936CB67B93A0AEE21",
                  "pub_key": {
                    "type": "tendermint/PubKeyEd25519",
                    "value": "BCJDOWiPAS5kneSOJBiACS6qj2qg9PFL/Pngx2kXwLY="
                  },
                  "voting_power": "100000000000",
                  "proposer_priority": "-100000000000"
                }
              },
              "proposal": {
                "Type": 32,
                "height": "9773742",
                "round": "0",
                "pol_round": "-1",
                "block_id": {
                  "hash": "8ACFE5C2B0A082A2662E135BDD416704199DD4A77A3716F8DD713A4AD5ABEBF3",
                  "parts": {
                    "total": "1",
                    "hash": "71AED818152AF7A3790408A05C707D3004F483EBCC0C1E6649098339012103F8"
                  }
                },
                "timestamp": "2019-04-21T14:11:14.214942826Z",
                "signature": "1AHILG0TgngZO9JA3I6TYd5s9zxcRNpeNyuj6YF39qt+TOzF1pMQlsqpCW3xXheRwOBzuaIMMNs6YXaA+n/DCQ=="
              },
              "proposal_block": {
                "header": {
                  "version": {
                    "block": "10",
                    "app": "0"
                  },
                  "chain_id": "Binance-Chain-Nile",
                  "height": "9773742",
                  "time": "2019-04-21T14:11:14.051876627Z",
                  "num_txs": "0",
                  "total_txs": "8645650",
                  "last_block_id": {
                    "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                    "parts": {
                      "total": "1",
                      "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                    }
                  },
                  "last_commit_hash": "3A564F3EBA289B1C92F6902EFB48EB3167B0B5B9ED62B3065DD215ED44292AF9",
                  "data_hash": "",
                  "validators_hash": "80D9AB0FC10D18CA0E0832D5F4C063C5489EC1443DFB738252D038A82131B27A",
                  "next_validators_hash": "80D9AB0FC10D18CA0E0832D5F4C063C5489EC1443DFB738252D038A82131B27A",
                  "consensus_hash": "294D8FBD0B94B767A7EBA9840F299A3586DA7FE6B5DEAD3B7EECBA193C400F93",
                  "app_hash": "1317ACCD931EF541988AB8F2171D6E32124A5F79DFECDC682E5AFCD45D8882B5",
                  "last_results_hash": "",
                  "evidence_hash": "",
                  "proposer_address": "E0DD72609CC106210D1AA13936CB67B93A0AEE21"
                },
                "data": {
                  "txs": null
                },
                "evidence": {
                  "evidence": null
                },
                "last_commit": {
                  "block_id": {
                    "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                    "parts": {
                      "total": "1",
                      "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                    }
                  },
                  "precommits": [
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.075393073Z",
                      "validator_address": "06FD60078EB4C2356137DD50036597DB267CF616",
                      "validator_index": "0",
                      "signature": "2BDMp+0fzZsK7mHTrL9EcazZIwbpzSs+YxCo/pOoe80x24bV1q9CGCoxA4ABBy29tUoyV6QwgJnzk4fNWMCmBQ=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.045739639Z",
                      "validator_address": "18E69CC672973992BB5F76D049A5B2C5DDF77436",
                      "validator_index": "1",
                      "signature": "Cx52QatD+xkvIXf27Hpu02zVRXMbBPUDtxdjMR3erdHWOcjlMTZLsequw3Rrqr6fDJ7Wu392eEaigGBth03tAg=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.051876627Z",
                      "validator_address": "344C39BB8F4512D6CAB1F6AAFAC1811EF9D8AFDF",
                      "validator_index": "2",
                      "signature": "lnCip6g9LHNQCTmYcckhicCbArN2dUZYevA6gh32c+qsbpxQOdiHSaXgQrRDXNv/WD+o0JN9ZX4ku556Zn/oCQ=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.082846321Z",
                      "validator_address": "37EF19AF29679B368D2B9E9DE3F8769B35786676",
                      "validator_index": "3",
                      "signature": "J66r5E30o8QW7jnJaWRvi04NJ2lLobHE4CBOYHtICSwxYpyr8O3bTJIpixnLpRZ1iYSMkfdMD4sh0RTyUAPTDw=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:13.958482008Z",
                      "validator_address": "62633D9DB7ED78E951F79913FDC8231AA77EC12B",
                      "validator_index": "4",
                      "signature": "DhKYmWc9uE8wEWaf5uc8w9mHoMi3BroyLqaZFEsEbcJhMnp4DIkWLoXR+rhV6Kn0hhmT4RIGTL5Lg3K7lrYcDw=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:13.965179246Z",
                      "validator_address": "7B343E041CA130000A8BC00C35152BD7E7740037",
                      "validator_index": "5",
                      "signature": "ZoRabUIBCnc+Z/2S4QrXCTqftirfnjAKBgyKh2a7D79ZZTrc7dZdLKrXFYK4z6FyGzBYKFjPF8b8tPJvbI7ODA=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.053040662Z",
                      "validator_address": "91844D296BD8E591448EFC65FD6AD51A888D58FA",
                      "validator_index": "6",
                      "signature": "BLgVUop9NaO9MtLo/NZI24iB3m+I+uUIvn81LQuOWX8N4WIHAMQE4QjCGgXPrG3i5iVMJ93MoR3u7mhHux+6BQ=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.053748883Z",
                      "validator_address": "B3727172CE6473BC780298A2D66C12F1A14F5B2A",
                      "validator_index": "7",
                      "signature": "t5qS50VlWFEuIu8XPSzahjYD4lVJRJkRifSIIQLyLztpG6JkW0LRXzhPr1d7WhTDNxl2+kWHT2nZnIz8xuBuBg=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.083227926Z",
                      "validator_address": "B6F20C7FAA2B2F6F24518FA02B71CB5F4A09FBA3",
                      "validator_index": "8",
                      "signature": "BzyQP8S8KUyYT193KjBoWajJ8SGetdFp3r/psBATfclvoQdCt+wolwterYgNAnUJ7aq5Otaw4Lt3PIVHFa3KAQ=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:13.968175864Z",
                      "validator_address": "E0DD72609CC106210D1AA13936CB67B93A0AEE21",
                      "validator_index": "9",
                      "signature": "gyhCUmXXpaAxjYgsU5iIuR+l152+GuzzQ2hr3XxLwRk5H7kpcwPzY115W6kTrptKJfxDIrze3lj9N0qoOdbIBg=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:13.957153527Z",
                      "validator_address": "FC3108DC3814888F4187452182BC1BAF83B71BC9",
                      "validator_index": "10",
                      "signature": "F5A7MYbkgFO5YeENPKIv9zVdD035OrDkDGHYZlmMnTV5J8LMLv5lmdE8Nsv1epVvCHzbRLJ5PyMArMAxYKKJBw=="
                    }
                  ]
                }
              },
              "proposal_block_parts": {
                "count/total": "1/1",
                "parts_bit_array": "x"
              },
              "locked_round": "0",
              "locked_block": {
                "header": {
                  "version": {
                    "block": "10",
                    "app": "0"
                  },
                  "chain_id": "Binance-Chain-Nile",
                  "height": "9773742",
                  "time": "2019-04-21T14:11:14.051876627Z",
                  "num_txs": "0",
                  "total_txs": "8645650",
                  "last_block_id": {
                    "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                    "parts": {
                      "total": "1",
                      "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                    }
                  },
                  "last_commit_hash": "3A564F3EBA289B1C92F6902EFB48EB3167B0B5B9ED62B3065DD215ED44292AF9",
                  "data_hash": "",
                  "validators_hash": "80D9AB0FC10D18CA0E0832D5F4C063C5489EC1443DFB738252D038A82131B27A",
                  "next_validators_hash": "80D9AB0FC10D18CA0E0832D5F4C063C5489EC1443DFB738252D038A82131B27A",
                  "consensus_hash": "294D8FBD0B94B767A7EBA9840F299A3586DA7FE6B5DEAD3B7EECBA193C400F93",
                  "app_hash": "1317ACCD931EF541988AB8F2171D6E32124A5F79DFECDC682E5AFCD45D8882B5",
                  "last_results_hash": "",
                  "evidence_hash": "",
                  "proposer_address": "E0DD72609CC106210D1AA13936CB67B93A0AEE21"
                },
                "data": {
                  "txs": null
                },
                "evidence": {
                  "evidence": null
                },
                "last_commit": {
                  "block_id": {
                    "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                    "parts": {
                      "total": "1",
                      "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                    }
                  },
                  "precommits": [
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.075393073Z",
                      "validator_address": "06FD60078EB4C2356137DD50036597DB267CF616",
                      "validator_index": "0",
                      "signature": "2BDMp+0fzZsK7mHTrL9EcazZIwbpzSs+YxCo/pOoe80x24bV1q9CGCoxA4ABBy29tUoyV6QwgJnzk4fNWMCmBQ=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.045739639Z",
                      "validator_address": "18E69CC672973992BB5F76D049A5B2C5DDF77436",
                      "validator_index": "1",
                      "signature": "Cx52QatD+xkvIXf27Hpu02zVRXMbBPUDtxdjMR3erdHWOcjlMTZLsequw3Rrqr6fDJ7Wu392eEaigGBth03tAg=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.051876627Z",
                      "validator_address": "344C39BB8F4512D6CAB1F6AAFAC1811EF9D8AFDF",
                      "validator_index": "2",
                      "signature": "lnCip6g9LHNQCTmYcckhicCbArN2dUZYevA6gh32c+qsbpxQOdiHSaXgQrRDXNv/WD+o0JN9ZX4ku556Zn/oCQ=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.082846321Z",
                      "validator_address": "37EF19AF29679B368D2B9E9DE3F8769B35786676",
                      "validator_index": "3",
                      "signature": "J66r5E30o8QW7jnJaWRvi04NJ2lLobHE4CBOYHtICSwxYpyr8O3bTJIpixnLpRZ1iYSMkfdMD4sh0RTyUAPTDw=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:13.958482008Z",
                      "validator_address": "62633D9DB7ED78E951F79913FDC8231AA77EC12B",
                      "validator_index": "4",
                      "signature": "DhKYmWc9uE8wEWaf5uc8w9mHoMi3BroyLqaZFEsEbcJhMnp4DIkWLoXR+rhV6Kn0hhmT4RIGTL5Lg3K7lrYcDw=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:13.965179246Z",
                      "validator_address": "7B343E041CA130000A8BC00C35152BD7E7740037",
                      "validator_index": "5",
                      "signature": "ZoRabUIBCnc+Z/2S4QrXCTqftirfnjAKBgyKh2a7D79ZZTrc7dZdLKrXFYK4z6FyGzBYKFjPF8b8tPJvbI7ODA=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.053040662Z",
                      "validator_address": "91844D296BD8E591448EFC65FD6AD51A888D58FA",
                      "validator_index": "6",
                      "signature": "BLgVUop9NaO9MtLo/NZI24iB3m+I+uUIvn81LQuOWX8N4WIHAMQE4QjCGgXPrG3i5iVMJ93MoR3u7mhHux+6BQ=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.053748883Z",
                      "validator_address": "B3727172CE6473BC780298A2D66C12F1A14F5B2A",
                      "validator_index": "7",
                      "signature": "t5qS50VlWFEuIu8XPSzahjYD4lVJRJkRifSIIQLyLztpG6JkW0LRXzhPr1d7WhTDNxl2+kWHT2nZnIz8xuBuBg=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.083227926Z",
                      "validator_address": "B6F20C7FAA2B2F6F24518FA02B71CB5F4A09FBA3",
                      "validator_index": "8",
                      "signature": "BzyQP8S8KUyYT193KjBoWajJ8SGetdFp3r/psBATfclvoQdCt+wolwterYgNAnUJ7aq5Otaw4Lt3PIVHFa3KAQ=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:13.968175864Z",
                      "validator_address": "E0DD72609CC106210D1AA13936CB67B93A0AEE21",
                      "validator_index": "9",
                      "signature": "gyhCUmXXpaAxjYgsU5iIuR+l152+GuzzQ2hr3XxLwRk5H7kpcwPzY115W6kTrptKJfxDIrze3lj9N0qoOdbIBg=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:13.957153527Z",
                      "validator_address": "FC3108DC3814888F4187452182BC1BAF83B71BC9",
                      "validator_index": "10",
                      "signature": "F5A7MYbkgFO5YeENPKIv9zVdD035OrDkDGHYZlmMnTV5J8LMLv5lmdE8Nsv1epVvCHzbRLJ5PyMArMAxYKKJBw=="
                    }
                  ]
                }
              },
              "locked_block_parts": {
                "count/total": "1/1",
                "parts_bit_array": "x"
              },
              "valid_round": "0",
              "valid_block": {
                "header": {
                  "version": {
                    "block": "10",
                    "app": "0"
                  },
                  "chain_id": "Binance-Chain-Nile",
                  "height": "9773742",
                  "time": "2019-04-21T14:11:14.051876627Z",
                  "num_txs": "0",
                  "total_txs": "8645650",
                  "last_block_id": {
                    "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                    "parts": {
                      "total": "1",
                      "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                    }
                  },
                  "last_commit_hash": "3A564F3EBA289B1C92F6902EFB48EB3167B0B5B9ED62B3065DD215ED44292AF9",
                  "data_hash": "",
                  "validators_hash": "80D9AB0FC10D18CA0E0832D5F4C063C5489EC1443DFB738252D038A82131B27A",
                  "next_validators_hash": "80D9AB0FC10D18CA0E0832D5F4C063C5489EC1443DFB738252D038A82131B27A",
                  "consensus_hash": "294D8FBD0B94B767A7EBA9840F299A3586DA7FE6B5DEAD3B7EECBA193C400F93",
                  "app_hash": "1317ACCD931EF541988AB8F2171D6E32124A5F79DFECDC682E5AFCD45D8882B5",
                  "last_results_hash": "",
                  "evidence_hash": "",
                  "proposer_address": "E0DD72609CC106210D1AA13936CB67B93A0AEE21"
                },
                "data": {
                  "txs": null
                },
                "evidence": {
                  "evidence": null
                },
                "last_commit": {
                  "block_id": {
                    "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                    "parts": {
                      "total": "1",
                      "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                    }
                  },
                  "precommits": [
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.075393073Z",
                      "validator_address": "06FD60078EB4C2356137DD50036597DB267CF616",
                      "validator_index": "0",
                      "signature": "2BDMp+0fzZsK7mHTrL9EcazZIwbpzSs+YxCo/pOoe80x24bV1q9CGCoxA4ABBy29tUoyV6QwgJnzk4fNWMCmBQ=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.045739639Z",
                      "validator_address": "18E69CC672973992BB5F76D049A5B2C5DDF77436",
                      "validator_index": "1",
                      "signature": "Cx52QatD+xkvIXf27Hpu02zVRXMbBPUDtxdjMR3erdHWOcjlMTZLsequw3Rrqr6fDJ7Wu392eEaigGBth03tAg=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.051876627Z",
                      "validator_address": "344C39BB8F4512D6CAB1F6AAFAC1811EF9D8AFDF",
                      "validator_index": "2",
                      "signature": "lnCip6g9LHNQCTmYcckhicCbArN2dUZYevA6gh32c+qsbpxQOdiHSaXgQrRDXNv/WD+o0JN9ZX4ku556Zn/oCQ=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.082846321Z",
                      "validator_address": "37EF19AF29679B368D2B9E9DE3F8769B35786676",
                      "validator_index": "3",
                      "signature": "J66r5E30o8QW7jnJaWRvi04NJ2lLobHE4CBOYHtICSwxYpyr8O3bTJIpixnLpRZ1iYSMkfdMD4sh0RTyUAPTDw=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:13.958482008Z",
                      "validator_address": "62633D9DB7ED78E951F79913FDC8231AA77EC12B",
                      "validator_index": "4",
                      "signature": "DhKYmWc9uE8wEWaf5uc8w9mHoMi3BroyLqaZFEsEbcJhMnp4DIkWLoXR+rhV6Kn0hhmT4RIGTL5Lg3K7lrYcDw=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:13.965179246Z",
                      "validator_address": "7B343E041CA130000A8BC00C35152BD7E7740037",
                      "validator_index": "5",
                      "signature": "ZoRabUIBCnc+Z/2S4QrXCTqftirfnjAKBgyKh2a7D79ZZTrc7dZdLKrXFYK4z6FyGzBYKFjPF8b8tPJvbI7ODA=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.053040662Z",
                      "validator_address": "91844D296BD8E591448EFC65FD6AD51A888D58FA",
                      "validator_index": "6",
                      "signature": "BLgVUop9NaO9MtLo/NZI24iB3m+I+uUIvn81LQuOWX8N4WIHAMQE4QjCGgXPrG3i5iVMJ93MoR3u7mhHux+6BQ=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.053748883Z",
                      "validator_address": "B3727172CE6473BC780298A2D66C12F1A14F5B2A",
                      "validator_index": "7",
                      "signature": "t5qS50VlWFEuIu8XPSzahjYD4lVJRJkRifSIIQLyLztpG6JkW0LRXzhPr1d7WhTDNxl2+kWHT2nZnIz8xuBuBg=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:14.083227926Z",
                      "validator_address": "B6F20C7FAA2B2F6F24518FA02B71CB5F4A09FBA3",
                      "validator_index": "8",
                      "signature": "BzyQP8S8KUyYT193KjBoWajJ8SGetdFp3r/psBATfclvoQdCt+wolwterYgNAnUJ7aq5Otaw4Lt3PIVHFa3KAQ=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:13.968175864Z",
                      "validator_address": "E0DD72609CC106210D1AA13936CB67B93A0AEE21",
                      "validator_index": "9",
                      "signature": "gyhCUmXXpaAxjYgsU5iIuR+l152+GuzzQ2hr3XxLwRk5H7kpcwPzY115W6kTrptKJfxDIrze3lj9N0qoOdbIBg=="
                    },
                    {
                      "type": 2,
                      "height": "9773741",
                      "round": "0",
                      "block_id": {
                        "hash": "11035FB84352DC93781E64298EC817A1D0BC65CA78AB924518BD652BB9845A30",
                        "parts": {
                          "total": "1",
                          "hash": "1E8D7E67440230559E47E4C092FBE42722BA2432A46F172E3EABAAFA840677B3"
                        }
                      },
                      "timestamp": "2019-04-21T14:11:13.957153527Z",
                      "validator_address": "FC3108DC3814888F4187452182BC1BAF83B71BC9",
                      "validator_index": "10",
                      "signature": "F5A7MYbkgFO5YeENPKIv9zVdD035OrDkDGHYZlmMnTV5J8LMLv5lmdE8Nsv1epVvCHzbRLJ5PyMArMAxYKKJBw=="
                    }
                  ]
                }
              },
              "valid_block_parts": {
                "count/total": "1/1",
                "parts_bit_array": "x"
              },
              "votes": [
                {
                  "round": "0",
                  "prevotes": [
                    "nil-Vote",
                    "Vote{1:18E69CC67297 9773742/00/1(Prevote) 8ACFE5C2B0A0 130A3EC8B3BA @ 2019-04-21T14:11:14.318960498Z}",
                    "Vote{2:344C39BB8F45 9773742/00/1(Prevote) 8ACFE5C2B0A0 8ADAB84CAE09 @ 2019-04-21T14:11:14.322971668Z}",
                    "nil-Vote",
                    "Vote{4:62633D9DB7ED 9773742/00/1(Prevote) 8ACFE5C2B0A0 9D335345FD68 @ 2019-04-21T14:11:14.237631548Z}",
                    "Vote{5:7B343E041CA1 9773742/00/1(Prevote) 8ACFE5C2B0A0 6659D344E821 @ 2019-04-21T14:11:14.240662808Z}",
                    "Vote{6:91844D296BD8 9773742/00/1(Prevote) 8ACFE5C2B0A0 1A0B50CAD6AF @ 2019-04-21T14:11:14.320681395Z}",
                    "Vote{7:B3727172CE64 9773742/00/1(Prevote) 8ACFE5C2B0A0 CF3787476973 @ 2019-04-21T14:11:14.31854911Z}",
                    "nil-Vote",
                    "Vote{9:E0DD72609CC1 9773742/00/1(Prevote) 8ACFE5C2B0A0 7BCAB951E5C2 @ 2019-04-21T14:11:14.222214681Z}",
                    "Vote{10:FC3108DC3814 9773742/00/1(Prevote) 8ACFE5C2B0A0 8907E4A2C6CC @ 2019-04-21T14:11:14.240001832Z}"
                  ],
                  "prevotes_bit_array": "BA{11:_xx_xxxx_xx} 800000000000/1100000000000 = 0.73",
                  "precommits": [
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "Vote{4:62633D9DB7ED 9773742/00/2(Precommit) 8ACFE5C2B0A0 CD858331A2D4 @ 2019-04-21T14:11:14.427006172Z}",
                    "Vote{5:7B343E041CA1 9773742/00/2(Precommit) 8ACFE5C2B0A0 478E0F2DF506 @ 2019-04-21T14:11:14.424972208Z}",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "Vote{9:E0DD72609CC1 9773742/00/2(Precommit) 8ACFE5C2B0A0 C71DC01F20C8 @ 2019-04-21T14:11:14.427814632Z}",
                    "Vote{10:FC3108DC3814 9773742/00/2(Precommit) 8ACFE5C2B0A0 410B948AA132 @ 2019-04-21T14:11:14.427303727Z}"
                  ],
                  "precommits_bit_array": "BA{11:____xx___xx} 400000000000/1100000000000 = 0.36"
                },
                {
                  "round": "1",
                  "prevotes": [
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote"
                  ],
                  "prevotes_bit_array": "BA{11:___________} 0/1100000000000 = 0.00",
                  "precommits": [
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote"
                  ],
                  "precommits_bit_array": "BA{11:___________} 0/1100000000000 = 0.00"
                }
              ],
              "commit_round": "-1",
              "last_commit": {
                "votes": [
                  "Vote{0:06FD60078EB4 9773741/00/2(Precommit) 11035FB84352 D810CCA7ED1F @ 2019-04-21T14:11:14.075393073Z}",
                  "Vote{1:18E69CC67297 9773741/00/2(Precommit) 11035FB84352 0B1E7641AB43 @ 2019-04-21T14:11:14.045739639Z}",
                  "Vote{2:344C39BB8F45 9773741/00/2(Precommit) 11035FB84352 9670A2A7A83D @ 2019-04-21T14:11:14.051876627Z}",
                  "Vote{3:37EF19AF2967 9773741/00/2(Precommit) 11035FB84352 27AEABE44DF4 @ 2019-04-21T14:11:14.082846321Z}",
                  "Vote{4:62633D9DB7ED 9773741/00/2(Precommit) 11035FB84352 0E129899673D @ 2019-04-21T14:11:13.958482008Z}",
                  "Vote{5:7B343E041CA1 9773741/00/2(Precommit) 11035FB84352 66845A6D4201 @ 2019-04-21T14:11:13.965179246Z}",
                  "Vote{6:91844D296BD8 9773741/00/2(Precommit) 11035FB84352 04B815528A7D @ 2019-04-21T14:11:14.053040662Z}",
                  "Vote{7:B3727172CE64 9773741/00/2(Precommit) 11035FB84352 B79A92E74565 @ 2019-04-21T14:11:14.053748883Z}",
                  "Vote{8:B6F20C7FAA2B 9773741/00/2(Precommit) 11035FB84352 073C903FC4BC @ 2019-04-21T14:11:14.083227926Z}",
                  "Vote{9:E0DD72609CC1 9773741/00/2(Precommit) 11035FB84352 8328425265D7 @ 2019-04-21T14:11:13.968175864Z}",
                  "Vote{10:FC3108DC3814 9773741/00/2(Precommit) 11035FB84352 17903B3186E4 @ 2019-04-21T14:11:13.957153527Z}"
                ],
                "votes_bit_array": "BA{11:xxxxxxxxxxx} 1100000000000/1100000000000 = 1.00",
                "peer_maj_23s": {}
              },
              "last_validators": {
                "validators": [
                  {
                    "address": "06FD60078EB4C2356137DD50036597DB267CF616",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "4Xy+nCDNz9+HazsSl40yZKAH/KqnHEzbcB2evAMj9E8="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-200000000000"
                  },
                  {
                    "address": "18E69CC672973992BB5F76D049A5B2C5DDF77436",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "GE57ED00xBAD+bhk1fjBrdqb0ENrJTuzyES8c5wed8k="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-200000000000"
                  },
                  {
                    "address": "344C39BB8F4512D6CAB1F6AAFAC1811EF9D8AFDF",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "TUIK6oQ+kqDP5p2JaW3/aCd2n5y1KiSa9TfOib8qS3Q="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-200000000000"
                  },
                  {
                    "address": "37EF19AF29679B368D2B9E9DE3F8769B35786676",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "vQPen4qynigACU4VP6xvaWz6USU2ycL4BNyywsTkrtY="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-200000000000"
                  },
                  {
                    "address": "62633D9DB7ED78E951F79913FDC8231AA77EC12B",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "j0p0oHNRiV3fNzBXuY+ubfryzSHzegY+GWAQeP5HDVM="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-200000000000"
                  },
                  {
                    "address": "7B343E041CA130000A8BC00C35152BD7E7740037",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "Sl1HU+t5+S6A7+It96yk9mak9Ev4HFNsSgnUucW2VLU="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-200000000000"
                  },
                  {
                    "address": "91844D296BD8E591448EFC65FD6AD51A888D58FA",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "yA6avvf/Q5wQxo/o8TA97d/FJ3GMOzfYumgHRG48gno="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-200000000000"
                  },
                  {
                    "address": "B3727172CE6473BC780298A2D66C12F1A14F5B2A",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "kUKvzGkbfMBdJsewvgyLRkGClBcXMOB584T94vpQuvw="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-200000000000"
                  },
                  {
                    "address": "B6F20C7FAA2B2F6F24518FA02B71CB5F4A09FBA3",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "SbKI5Ou7OigcLVRvwwJT1brwiZO25dKV+3h6WzFKKY4="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "-200000000000"
                  },
                  {
                    "address": "E0DD72609CC106210D1AA13936CB67B93A0AEE21",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "BCJDOWiPAS5kneSOJBiACS6qj2qg9PFL/Pngx2kXwLY="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "900000000000"
                  },
                  {
                    "address": "FC3108DC3814888F4187452182BC1BAF83B71BC9",
                    "pub_key": {
                      "type": "tendermint/PubKeyEd25519",
                      "value": "QDSzfO2ooL8Tsauu7nqPk4NUIJmlVNIZuT0M5p45cOg="
                    },
                    "voting_power": "100000000000",
                    "proposer_priority": "900000000000"
                  }
                ],
                "proposer": {
                  "address": "B6F20C7FAA2B2F6F24518FA02B71CB5F4A09FBA3",
                  "pub_key": {
                    "type": "tendermint/PubKeyEd25519",
                    "value": "SbKI5Ou7OigcLVRvwwJT1brwiZO25dKV+3h6WzFKKY4="
                  },
                  "voting_power": "100000000000",
                  "proposer_priority": "-200000000000"
                }
              },
              "triggered_timeout_precommit": false
            },
            "peers": [
              {
                "node_address": "8c379d4d3b9995c712665dc9a9414dbde5b30483@13.230.214.103:27146",
                "peer_state": {
                  "round_state": {
                    "height": "9773742",
                    "round": "0",
                    "step": 4,
                    "start_time": "2019-04-21T14:11:14.296072644Z",
                    "proposal": true,
                    "proposal_block_parts_header": {
                      "total": "1",
                      "hash": "71AED818152AF7A3790408A05C707D3004F483EBCC0C1E6649098339012103F8"
                    },
                    "proposal_block_parts": "x",
                    "proposal_pol_round": "-1",
                    "proposal_pol": "___________",
                    "prevotes": "____xx___xx",
                    "precommits": "___________",
                    "last_commit_round": "0",
                    "last_commit": null,
                    "catchup_commit_round": "-1",
                    "catchup_commit": "___________"
                  },
                  "stats": {
                    "votes": "356369",
                    "block_parts": "32452"
                  }
                }
              },
              {
                "node_address": "84ad762f4cdaad6942325dadf12f045c4e10d29a@10.201.41.248:27146",
                "peer_state": {
                  "round_state": {
                    "height": "9773742",
                    "round": "0",
                    "step": 4,
                    "start_time": "2019-04-21T14:11:14.271326324Z",
                    "proposal": true,
                    "proposal_block_parts_header": {
                      "total": "1",
                      "hash": "71AED818152AF7A3790408A05C707D3004F483EBCC0C1E6649098339012103F8"
                    },
                    "proposal_block_parts": "x",
                    "proposal_pol_round": "-1",
                    "proposal_pol": "___________",
                    "prevotes": "__x_xx___xx",
                    "precommits": "___________",
                    "last_commit_round": "0",
                    "last_commit": "x__x____x__",
                    "catchup_commit_round": "-1",
                    "catchup_commit": "___________"
                  },
                  "stats": {
                    "votes": "13989627",
                    "block_parts": "641577"
                  }
                }
              },
              {
                "node_address": "aea74b16d28d06cbfbb1179c177e8cd71315cce4@52.199.237.19:27146",
                "peer_state": {
                  "round_state": {
                    "height": "9773742",
                    "round": "0",
                    "step": 4,
                    "start_time": "2019-04-21T14:11:14.332152229Z",
                    "proposal": true,
                    "proposal_block_parts_header": {
                      "total": "1",
                      "hash": "71AED818152AF7A3790408A05C707D3004F483EBCC0C1E6649098339012103F8"
                    },
                    "proposal_block_parts": "x",
                    "proposal_pol_round": "-1",
                    "proposal_pol": "___________",
                    "prevotes": "____xx___xx",
                    "precommits": "___________",
                    "last_commit_round": "0",
                    "last_commit": null,
                    "catchup_commit_round": "-1",
                    "catchup_commit": "___________"
                  },
                  "stats": {
                    "votes": "1914",
                    "block_parts": "93"
                  }
                }
              },
              {
                "node_address": "7156d461742e2a1e569fd68426009c4194830c93@13.112.215.16:27146",
                "peer_state": {
                  "round_state": {
                    "height": "9773742",
                    "round": "0",
                    "step": 4,
                    "start_time": "2019-04-21T14:11:14.285528729Z",
                    "proposal": true,
                    "proposal_block_parts_header": {
                      "total": "1",
                      "hash": "71AED818152AF7A3790408A05C707D3004F483EBCC0C1E6649098339012103F8"
                    },
                    "proposal_block_parts": "x",
                    "proposal_pol_round": "-1",
                    "proposal_pol": "___________",
                    "prevotes": "__x_xx___xx",
                    "precommits": "___________",
                    "last_commit_round": "0",
                    "last_commit": "___________",
                    "catchup_commit_round": "-1",
                    "catchup_commit": "___________"
                  },
                  "stats": {
                    "votes": "293857",
                    "block_parts": "36195"
                  }
                }
              },
              {
                "node_address": "3c2b4071c486c2faed92f2b360aacea73415c08e@10.201.41.94:27146",
                "peer_state": {
                  "round_state": {
                    "height": "9773742",
                    "round": "0",
                    "step": 8,
                    "start_time": "2019-04-21T14:11:14.45921761Z",
                    "proposal": true,
                    "proposal_block_parts_header": {
                      "total": "1",
                      "hash": "71AED818152AF7A3790408A05C707D3004F483EBCC0C1E6649098339012103F8"
                    },
                    "proposal_block_parts": "x",
                    "proposal_pol_round": "-1",
                    "proposal_pol": "___________",
                    "prevotes": "_xx_xxxx_xx",
                    "precommits": "_xx_xxxx_xx",
                    "last_commit_round": "0",
                    "last_commit": "x__x___xx__",
                    "catchup_commit_round": "-1",
                    "catchup_commit": "___________"
                  },
                  "stats": {
                    "votes": "8532116",
                    "block_parts": "398204"
                  }
                }
              },
              {
                "node_address": "b4126f460ecb22e70f1374c4fd492a48a6cbd43b@0.0.0.0:26656",
                "peer_state": {
                  "round_state": {
                    "height": "9773742",
                    "round": "0",
                    "step": 4,
                    "start_time": "2019-04-21T14:11:14.347264163Z",
                    "proposal": true,
                    "proposal_block_parts_header": {
                      "total": "1",
                      "hash": "71AED818152AF7A3790408A05C707D3004F483EBCC0C1E6649098339012103F8"
                    },
                    "proposal_block_parts": "x",
                    "proposal_pol_round": "-1",
                    "proposal_pol": "___________",
                    "prevotes": "_xx_xxxx_xx",
                    "precommits": "____xx___xx",
                    "last_commit_round": "0",
                    "last_commit": "xxxxxxxxxxx",
                    "catchup_commit_round": "-1",
                    "catchup_commit": "___________"
                  },
                  "stats": {
                    "votes": "74",
                    "block_parts": "0"
                  }
                }
              },
              {
                "node_address": "2eb458f9d6adfc8ee4cdf3e025c43c43d46fb10a@0.0.0.0:26656",
                "peer_state": {
                  "round_state": {
                    "height": "0",
                    "round": "-1",
                    "step": 0,
                    "start_time": "0001-01-01T00:00:00Z",
                    "proposal": false,
                    "proposal_block_parts_header": {
                      "total": "0",
                      "hash": ""
                    },
                    "proposal_block_parts": null,
                    "proposal_pol_round": "-1",
                    "proposal_pol": null,
                    "prevotes": null,
                    "precommits": null,
                    "last_commit_round": "-1",
                    "last_commit": null,
                    "catchup_commit_round": "-1",
                    "catchup_commit": null
                  },
                  "stats": {
                    "votes": "0",
                    "block_parts": "0"
                  }
                }
              },
              {
                "node_address": "c57d7e2ddb872cf40dae201e293cb3a5d5e55874@0.0.0.0:28656",
                "peer_state": {
                  "round_state": {
                    "height": "9773742",
                    "round": "0",
                    "step": 1,
                    "start_time": "2019-04-21T14:11:14.372849775Z",
                    "proposal": true,
                    "proposal_block_parts_header": {
                      "total": "1",
                      "hash": "71AED818152AF7A3790408A05C707D3004F483EBCC0C1E6649098339012103F8"
                    },
                    "proposal_block_parts": "x",
                    "proposal_pol_round": "-1",
                    "proposal_pol": "___________",
                    "prevotes": "_xx_xxxx_xx",
                    "precommits": "____xx___xx",
                    "last_commit_round": "0",
                    "last_commit": "xxxxxxxxxxx",
                    "catchup_commit_round": "-1",
                    "catchup_commit": "___________"
                  },
                  "stats": {
                    "votes": "64",
                    "block_parts": "0"
                  }
                }
              }
            ]
          }
        }
    */

    public class PubKey
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Validator
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("pub_key")]
        public PubKey PubKey { get; set; }

        [JsonProperty("voting_power")]
        public string VotingPower { get; set; }

        [JsonProperty("proposer_priority")]
        public string ProposerPriority { get; set; }
    }

    public class DumpValidators
    {
        [JsonProperty("validators")]
        public List<Validator> Validators { get; set; }

        [JsonProperty("proposer")]
        public Validator Proposer { get; set; }
    }

    public class BlockIdPart
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class BlockId
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("parts")]
        public BlockIdPart Parts { get; set; }
    }

    public class DumpProposal
    {
        [JsonProperty("Type")]
        public int Type { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("round")]
        public string Round { get; set; }

        [JsonProperty("pol_round")]
        public string PolRound { get; set; }

        [JsonProperty("block_id")]
        public BlockId BlockId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }
    }

    public class BlockHeaderVersion
    {
        [JsonProperty("block")]
        public string Block { get; set; }

        [JsonProperty("app")]
        public string App { get; set; }
    }

    public class BlockHeader
    {
        [JsonProperty("version")]
        public BlockHeaderVersion Version { get; set; }

        [JsonProperty("chain_id")]
        public string ChainId { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("num_txs")]
        public string NumTxs { get; set; }

        [JsonProperty("total_txs")]
        public string TotalTxs { get; set; }

        [JsonProperty("last_block_id")]
        public BlockId LastBlockId { get; set; }

        [JsonProperty("last_commit_hash")]
        public string LastCommitHash { get; set; }

        [JsonProperty("data_hash")]
        public string DataHash { get; set; }

        [JsonProperty("validators_hash")]
        public string ValidatorsHash { get; set; }

        [JsonProperty("next_validators_hash")]
        public string NextValidatorsHash { get; set; }

        [JsonProperty("consensus_hash")]
        public string ConsensusHash { get; set; }

        [JsonProperty("app_hash")]
        public string AppHash { get; set; }

        [JsonProperty("last_results_hash")]
        public string LastResultsHash { get; set; }

        [JsonProperty("evidence_hash")]
        public string EvidenceHash { get; set; }

        [JsonProperty("proposer_address")]
        public string ProposerAddress { get; set; }
    }

    public class BlockData
    {
        [JsonProperty("txs")]
        public List<string> Txs { get; set; } // TODO No example available
    }

    public class BlockEvidence
    {
        [JsonProperty("evidence")]
        public string Evidence { get; set; } // TODO  No example available
    }

    public class BlockCommitPrecommit
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("round")]
        public string Round { get; set; }

        [JsonProperty("block_id")]
        public BlockId BlockId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("validator_address")]
        public string ValidatorAddress { get; set; }

        [JsonProperty("validator_index")]
        public string ValidatorIndex { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }
    }

    public class BlockCommit
    {
        [JsonProperty("block_id")]
        public BlockId BlockId { get; set; }

        [JsonProperty("precommits")]
        public List<BlockCommitPrecommit> Precommits { get; set; }
    }

    public class Block
    {
        [JsonProperty("header")]
        public BlockHeader Header { get; set; }

        [JsonProperty("data")]
        public BlockData Data { get; set; }

        [JsonProperty("evidence")]
        public BlockEvidence Evidence { get; set; }

        [JsonProperty("last_commit")]
        public BlockCommit LastCommit { get; set; }
    }

    public class DumpBlockParts
    {
        [JsonProperty("count/total")]
        public string CountTotal { get; set; }

        [JsonProperty("parts_bit_array")]
        public string PartsBitArray { get; set; }
    }

    public class DumpLastCommitPeerMaj23s
    {
        // TODO No example available
    }

    public class DumpLastCommit
    {
        [JsonProperty("votes")]
        public List<string> Votes { get; set; }

        [JsonProperty("votes_bit_array")]
        public string VotesBitArray { get; set; }

        [JsonProperty("peer_maj_23s")]
        public DumpLastCommitPeerMaj23s PeerMaj23s { get; set; }

    }

    public class DumpRoundStateInfo
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("round")]
        public string Round { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("commit_time")]
        public string CommitTime { get; set; }

        [JsonProperty("validators")]
        public DumpValidators Validators { get; set; }

        [JsonProperty("proposal")]
        public DumpProposal Proposal { get; set; }

        [JsonProperty("proposal_block")]
        public Block ProposalBlock { get; set; }

        [JsonProperty("proposal_block_parts")]
        public DumpBlockParts ProposalBlockParts { get; set; }

        [JsonProperty("locked_round")]
        public string LockedRound { get; set; }

        [JsonProperty("locked_block")]
        public Block LockedBlock { get; set; }

        [JsonProperty("locked_block_parts")]
        public DumpBlockParts LockedBlockParts { get; set; }

        [JsonProperty("valid_round")]
        public string ValidRound { get; set; }

        [JsonProperty("valid_block")]
        public Block ValidBlock { get; set; }

        [JsonProperty("valid_block_parts")]
        public DumpBlockParts ValidBlockParts { get; set; }

        [JsonProperty("votes")]
        public List<VoteSet> Votes { get; set; }

        [JsonProperty("commit_round")]
        public string CommitRound { get; set; }

        [JsonProperty("last_commit")]
        public DumpLastCommit LastCommit { get; set; }

        [JsonProperty("last_validators")]
        public DumpValidators LastValidators { get; set; }

        [JsonProperty("triggered_timeout_precommit")]
        public bool TriggeredTimeoutPrecommit { get; set; }
    }

    public class PeerStateRoundStateBlockPartsHeader
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class PeerStateRoundState
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("round")]
        public string Round { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("proposal")]
        public bool Proposal { get; set; }

        [JsonProperty("proposal_block_parts_header")]
        public PeerStateRoundStateBlockPartsHeader ProposalBlockPartsHeader { get; set; }

        [JsonProperty("proposal_block_parts")]
        public string ProposalBlockParts { get; set; }

        [JsonProperty("proposal_pol_round")]
        public string ProposalPolRound { get; set; }

        [JsonProperty("proposal_pol")]
        public string ProposalPol { get; set; }

        [JsonProperty("prevotes")]
        public string Prevotes { get; set; }

        [JsonProperty("precommits")]
        public string Precommits { get; set; }

        [JsonProperty("last_commit_round")]
        public string LastCommitRound { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("last_commit")]
        public string LastCommit { get; set; }

        [JsonProperty("catchup_commit_round")]
        public string CatchupCommitRound { get; set; }

        [JsonProperty("catchup_commit")]
        public string CatchupCommit { get; set; }
    }

    public class PeerStateStats
    {
        [JsonProperty("votes")]
        public string Votes { get; set; }

        [JsonProperty("block_parts")]
        public string BlockParts { get; set; }
    }

    public class PeerState
    {
        [JsonProperty("round_state")]
        public PeerStateRoundState RoundState { get; set; }

        [JsonProperty("stats")]
        public PeerStateStats Stats { get; set; }
    }

    public class Peer
    {
        [JsonProperty("node_address")]
        public string NodeAddress { get; set; }

        [JsonProperty("peer_state")]
        public PeerState PeerState { get; set; }
    }

    public class DumpRoundStateData : IEndpointResponse
    {
        [JsonProperty("round_state")]
        public DumpRoundStateInfo RoundState { get; set; }

        [JsonProperty("peers")]
        public List<Peer> Peers { get; set; }
    }
}
