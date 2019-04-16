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

        public static string ToOption(long option)
        {
            switch (option)
            {
                case 1:
                    return VoteOptionYes;
                case 2:
                    return VoteOptionAbstain;
                case 3:
                    return VoteOptionNo;
                case 4:
                    return VoteOptionNoWithVeto;
                default:
                    return VoteOptionDefault;
            }
        }

        public static long ToOption(string option)
        {
            switch (option)
            {
                case VoteOptionYes:
                    return 1;
                case VoteOptionAbstain:
                    return 2;
                case VoteOptionNo:
                    return 3;
                case VoteOptionNoWithVeto:
                    return 4;
                default:
                    return 0;
            }
        }

        //@JsonSerialize(using = ToStringSerializer.class) // long
        [JsonProperty("proposal_id", Order = 2)]
        public string ProposalId { get; set; }

        [JsonProperty("voter", Order = 3)]
        public string Voter { get; set; }

        [JsonProperty("option", Order = 1)]
        public string Option { get; set; }
    }
}
