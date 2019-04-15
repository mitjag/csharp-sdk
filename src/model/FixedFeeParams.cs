using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class FixedFeeParams
    {
        /// <summary>
        /// msg_type string Transaction msg type that this fee applies to submit_proposal
        /// </summary>
        [JsonProperty("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// fee number  The fixed fee amount    1000000000
        /// </summary>
        [JsonProperty("fee")]
        public decimal Fee { get; set; }

        /// <summary>
        /// fee_for     integer     1 = proposer, 2 = all, 3 = free     1
        /// </summary>
        [JsonProperty("fee_for")]
        public int FeeFor { get; set; }
    }
}
