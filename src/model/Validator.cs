using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class ValidatorInfo
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("pub_key")]
        public List<int> PubKey { get; set; }

        [JsonProperty("voting_power")]
        public long VotingPower { get; set; }
    }

    public class Validator
    {
        [JsonProperty("block_height")]
        public long BlockHeight { get; set; }

        [JsonProperty("validators")] 
        public List<ValidatorInfo> Validators { get; set; }
    }
}
