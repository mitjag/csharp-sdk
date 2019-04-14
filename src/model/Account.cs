using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class Account
    {
        /// <summary>
        /// account_number integer
        /// </summary>
        [JsonProperty("account_number")]
        public int AccountNumber { get; set; }

        /// <summary>
        /// address string (address)
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// balances[Balance]
        /// </summary>
        [JsonProperty("balances")]
        public List<Balance> Balances { get; set; }

        /// <summary>
        /// public_key[integer] Public key bytes
        /// </summary>
        [JsonProperty("public_key")]
        public List<int> PublicKey { get; set; }

        /// <summary>
        /// sequence long sequence is for preventing replay attack
        /// </summary>
        [JsonProperty("sequence")]
        public long Sequence { get; set; }
    }
}
