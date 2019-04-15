using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.message
{
    /// <summary>
    /// Json property order is alphabetic
    /// </summary>
    public class VoteMessage : ITransactionMessage
    {
        public const string VoteOptionYes = "Yes";
        public const string VoteOptionAbstain = "Abstain";
        public const string VoteOptionNo = "No";
        public const string VoteOptionNoWithVeto = "NoWithVeto";
        public const string VoteOptionDefault = "";

        //@JsonSerialize(using = ToStringSerializer.class) // long
        [JsonProperty("proposal_id", Order = 2)]
        public string ProposalId { get; set; }

        [JsonProperty("voter", Order = 3)]
        public string Voter { get; set; }

        [JsonProperty("option", Order = 1)]
        public string Option { get; set; }
    }
}
