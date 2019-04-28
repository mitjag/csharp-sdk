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
            "block_height": "10779111",
            "validators": [
              {
                "address": "06FD60078EB4C2356137DD50036597DB267CF616",
                "pub_key": {
                  "type": "tendermint/PubKeyEd25519",
                  "value": "4Xy+nCDNz9+HazsSl40yZKAH/KqnHEzbcB2evAMj9E8="
                },
                "voting_power": "100000000000",
                "proposer_priority": "-1000000000000"
              },
              {
                "address": "18E69CC672973992BB5F76D049A5B2C5DDF77436",
                "pub_key": {
                  "type": "tendermint/PubKeyEd25519",
                  "value": "GE57ED00xBAD+bhk1fjBrdqb0ENrJTuzyES8c5wed8k="
                },
                "voting_power": "100000000000",
                "proposer_priority": "100000000000"
              },
              {
                "address": "344C39BB8F4512D6CAB1F6AAFAC1811EF9D8AFDF",
                "pub_key": {
                  "type": "tendermint/PubKeyEd25519",
                  "value": "TUIK6oQ+kqDP5p2JaW3/aCd2n5y1KiSa9TfOib8qS3Q="
                },
                "voting_power": "100000000000",
                "proposer_priority": "100000000000"
              },
              {
                "address": "37EF19AF29679B368D2B9E9DE3F8769B35786676",
                "pub_key": {
                  "type": "tendermint/PubKeyEd25519",
                  "value": "vQPen4qynigACU4VP6xvaWz6USU2ycL4BNyywsTkrtY="
                },
                "voting_power": "100000000000",
                "proposer_priority": "100000000000"
              },
              {
                "address": "62633D9DB7ED78E951F79913FDC8231AA77EC12B",
                "pub_key": {
                  "type": "tendermint/PubKeyEd25519",
                  "value": "j0p0oHNRiV3fNzBXuY+ubfryzSHzegY+GWAQeP5HDVM="
                },
                "voting_power": "100000000000",
                "proposer_priority": "100000000000"
              },
              {
                "address": "7B343E041CA130000A8BC00C35152BD7E7740037",
                "pub_key": {
                  "type": "tendermint/PubKeyEd25519",
                  "value": "Sl1HU+t5+S6A7+It96yk9mak9Ev4HFNsSgnUucW2VLU="
                },
                "voting_power": "100000000000",
                "proposer_priority": "100000000000"
              },
              {
                "address": "91844D296BD8E591448EFC65FD6AD51A888D58FA",
                "pub_key": {
                  "type": "tendermint/PubKeyEd25519",
                  "value": "yA6avvf/Q5wQxo/o8TA97d/FJ3GMOzfYumgHRG48gno="
                },
                "voting_power": "100000000000",
                "proposer_priority": "100000000000"
              },
              {
                "address": "B3727172CE6473BC780298A2D66C12F1A14F5B2A",
                "pub_key": {
                  "type": "tendermint/PubKeyEd25519",
                  "value": "kUKvzGkbfMBdJsewvgyLRkGClBcXMOB584T94vpQuvw="
                },
                "voting_power": "100000000000",
                "proposer_priority": "100000000000"
              },
              {
                "address": "B6F20C7FAA2B2F6F24518FA02B71CB5F4A09FBA3",
                "pub_key": {
                  "type": "tendermint/PubKeyEd25519",
                  "value": "SbKI5Ou7OigcLVRvwwJT1brwiZO25dKV+3h6WzFKKY4="
                },
                "voting_power": "100000000000",
                "proposer_priority": "100000000000"
              },
              {
                "address": "E0DD72609CC106210D1AA13936CB67B93A0AEE21",
                "pub_key": {
                  "type": "tendermint/PubKeyEd25519",
                  "value": "BCJDOWiPAS5kneSOJBiACS6qj2qg9PFL/Pngx2kXwLY="
                },
                "voting_power": "100000000000",
                "proposer_priority": "100000000000"
              },
              {
                "address": "FC3108DC3814888F4187452182BC1BAF83B71BC9",
                "pub_key": {
                  "type": "tendermint/PubKeyEd25519",
                  "value": "QDSzfO2ooL8Tsauu7nqPk4NUIJmlVNIZuT0M5p45cOg="
                },
                "voting_power": "100000000000",
                "proposer_priority": "100000000000"
              }
            ]
          }
        }
    */

    public class ResultValidators : IEndpointResponse
    {
        [JsonProperty("block_height")]
        public string BlockHeight { get; set; }

        [JsonProperty("validators")]
        public List<Validator> Validators { get; set; }
    }
}
