using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.message
{
    //@JsonIgnoreProperties(ignoreUnknown = true)
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
        [JsonProperty("proposal_id")]
        private string ProposalId;

        [JsonProperty("voter")]
        private string Voter;

        [JsonProperty("option")]
        private string Option;
    }
}
