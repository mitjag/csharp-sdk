using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class AccountSequence
    {
        /// <summary>
        /// sequence long number used for preventing replay attack 	1
        /// </summary>
        [JsonProperty("sequence")]
        public long Sequence { get; set; }
    }
}
