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
              "height/round/step": "9752742/0/6",
              "start_time": "2019-04-21T11:53:57.884207135Z",
              "proposal_block_hash": "20D641F717D45130AC22D5FA5EACDC24F0178EBD511E51C487DFE49A79010253",
              "locked_block_hash": "20D641F717D45130AC22D5FA5EACDC24F0178EBD511E51C487DFE49A79010253",
              "valid_block_hash": "20D641F717D45130AC22D5FA5EACDC24F0178EBD511E51C487DFE49A79010253",
              "height_vote_set": [
                {
                  "round": "0",
                  "prevotes": [
                    "Vote{0:06FD60078EB4 9752742/00/1(Prevote) 20D641F717D4 6D3EC8930E21 @ 2019-04-21T11:53:56.82237884Z}",
                    "Vote{1:18E69CC67297 9752742/00/1(Prevote) 20D641F717D4 EF7D91C9C05A @ 2019-04-21T11:53:56.859578166Z}",
                    "Vote{2:344C39BB8F45 9752742/00/1(Prevote) 20D641F717D4 16FACCA084C7 @ 2019-04-21T11:53:56.860921802Z}",
                    "Vote{3:37EF19AF2967 9752742/00/1(Prevote) 20D641F717D4 0EB36C4EED7E @ 2019-04-21T11:53:56.822678346Z}",
                    "Vote{4:62633D9DB7ED 9752742/00/1(Prevote) 20D641F717D4 26E18EAF959C @ 2019-04-21T11:53:57.029787088Z}",
                    "Vote{5:7B343E041CA1 9752742/00/1(Prevote) 20D641F717D4 6C656641BA51 @ 2019-04-21T11:53:57.01963698Z}",
                    "Vote{6:91844D296BD8 9752742/00/1(Prevote) 20D641F717D4 3F46DBC55B5C @ 2019-04-21T11:53:56.869764445Z}",
                    "Vote{7:B3727172CE64 9752742/00/1(Prevote) 20D641F717D4 DEC42A4FA452 @ 2019-04-21T11:53:56.860637234Z}",
                    "Vote{8:B6F20C7FAA2B 9752742/00/1(Prevote) 20D641F717D4 1B353D816727 @ 2019-04-21T11:53:56.797132541Z}",
                    "Vote{9:E0DD72609CC1 9752742/00/1(Prevote) 20D641F717D4 2A7C7EB42E96 @ 2019-04-21T11:53:57.029887452Z}",
                    "Vote{10:FC3108DC3814 9752742/00/1(Prevote) 20D641F717D4 3AE8CADAD012 @ 2019-04-21T11:53:57.018905522Z}"
                  ],
                  "prevotes_bit_array": "BA{11:xxxxxxxxxxx} 1100000000000/1100000000000 = 1.00",
                  "precommits": [
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "Vote{4:62633D9DB7ED 9752742/00/2(Precommit) 20D641F717D4 31DF893D495B @ 2019-04-21T11:53:57.037631494Z}",
                    "Vote{5:7B343E041CA1 9752742/00/2(Precommit) 20D641F717D4 365537BE1607 @ 2019-04-21T11:53:57.027341555Z}",
                    "nil-Vote",
                    "nil-Vote",
                    "nil-Vote",
                    "Vote{9:E0DD72609CC1 9752742/00/2(Precommit) 20D641F717D4 0E96FA3BC52B @ 2019-04-21T11:53:57.038544188Z}",
                    "Vote{10:FC3108DC3814 9752742/00/2(Precommit) 20D641F717D4 5E786B856241 @ 2019-04-21T11:53:57.026739681Z}"
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
              ]
            }
          }
        }
    */

    public class VoteSet
    {
        [JsonProperty("round")]
        public string Round { get; set; }

        [JsonProperty("prevotes")]
        public List<string> Prevotes { get; set; }

        [JsonProperty("prevotes_bit_array")]
        public string PrevotesBitArray { get; set; }

        [JsonProperty("precommits")]
        public List<string> Precommits { get; set; }

        [JsonProperty("precommits_bit_array")]
        public string PrecommitsBitArray { get; set; }
    }

    public class ConsensusRoundStateInfo
    {
        [JsonProperty("height/round/step")]
        public string HeightRoundStep { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("proposal_block_hash")]
        public string ProposalBlockHash { get; set; }

        [JsonProperty("locked_block_hash")]
        public string LockedBlockHash { get; set; }

        [JsonProperty("height_vote_set")]
        public List<VoteSet> HeightVoteSets { get; set; }
    }

    public class ConsensusRoundStateData : IEndpointResponse
    {
        [JsonProperty("round_state")]
        public ConsensusRoundStateInfo RoundState { get; set; }
    }
}
