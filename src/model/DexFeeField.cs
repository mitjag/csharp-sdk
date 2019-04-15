using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class DexFeeField
    {
        [JsonProperty("fee_name")]
        public string FeeName { get; set; }

        [JsonProperty("fee_value")]
        public decimal FeeValue { get; set; }
    }
}
