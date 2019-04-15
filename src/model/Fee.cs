using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class FeeData
    {
        /// <summary>
        /// msg_type string Transaction msg type that this fee applies to submit_proposal
        /// </summary>
        [JsonProperty("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// fee number  The fee amount  1000000000
        /// </summary>
        [JsonProperty("fee")]
        public decimal Fee { get; set; }

        /// <summary>
        /// fee_for integer 	1 = proposer, 2 = all, 3 = free     1
        /// </summary>
        [JsonProperty("fee_for")]
        public int FeeFor { get; set; }

        /// <summary>
        /// multi_transfer_fee  string Fee for multi-transfer  200000
        /// </summary>
        [JsonProperty("multi_transfer_fee")]
        public string MultiTransferFee { get; set; }

        /// <summary>
        /// lower_limit_as_multi    string e.g. 2 	2
        /// </summary>
        [JsonProperty("lower_limit_as_multi")]
        public string LowerLimitAsMulti { get; set; }

        /// <summary>
        /// fixed_fee_params FixedFeeParams  Set if the fee is fixed
        /// </summary>
        [JsonProperty("fixed_fee_params")]
        public FixedFeeParams FixedFeeParams { get; set; }

        [JsonProperty("dex_fee_fields")]
        public List<DexFeeField> DexFeeFields { get; set; }
    }
}
