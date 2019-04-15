using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class Market
    {
        /// <summary>
        /// base_asset_symbol string (currency) symbol of base asset BNB
        /// </summary>
        [JsonProperty("base_asset_symbol")]
        public string BaseAssetSymbol { get; set; }

        /// <summary>
        /// quote_asset_symbol string (currency) symbol of quote asset ABC
        /// </summary>
        [JsonProperty("quote_asset_symbol")]
        public string QuoteAssetSymbol { get; set; }

        /// <summary>
        /// price string (fixed8) In decimal form, e.g. 1.00000000 	0.00000000
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// tick_size string (fixed8) Minimium price change in decimal form, e.g. 1.00000000 	0.00000001
        /// </summary>
        [JsonProperty("tick_size")]
        public string TickSize { get; set; }

        /// <summary>
        /// lot_size string (fixed8) Minimium trading quantity in decimal form, e.g. 1.00000000 	0.000001
        /// </summary>
        [JsonProperty("lot_size")]
        public string LotSize { get; set; }
    }
}
