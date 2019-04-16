using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class Tx
    {
        /*
             {
              "txHash": "15101D3461FF797A92EA09DDE86BA6EDA323DCCF3BFB75FDA2D8E10085C01907",
              "blockHeight": 8602968,
              "txType": "CANCEL_ORDER",
              "timeStamp": "2019-04-16T04:47:11.969Z",
              "fromAddr": "tbnb1e46rgv62c27fd60agqx2kguytj0ddtkk9avjt9",
              "toAddr": null,
              "value": null,
              "txAsset": null,
              "txFee": "0.00000000",
              "txAge": 86,
              "orderId": null,
              "code": 0,
              "data": "{\"orderData\":{\"symbol\":\"XRP.B-585_BNB\",\"orderType\":\"limit\",\"side\":\"sell\",\"price\":0.01709680,\"quantity\":6948.50000000,\"timeInForce\":\"GTE\",\"orderId\":\"CD7434334AC2BC96E9FD400CAB23845C9ED6AED6-25933\"}}",
              "confirmBlocks": 0
            }
        */

        /// <summary>
        /// txHash  string hash of transaction
        /// </summary>
        [JsonProperty("txHash")]
        public string TxHash { get; set; }

        /// <summary>
        /// blockHeight long block height
        /// </summary>
        [JsonProperty("blockHeight")]
        public long BlockHeight { get; set; }

        /// <summary>
        /// txType string type of transaction
        /// </summary>
        [JsonProperty("txType")]
        public string TxType { get; set; }

        /// <summary>
        /// timeStamp   dateTime time of transaction
        /// </summary>
        [JsonProperty("timeStamp")]
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// fromAddr    string from address
        /// </summary>
        [JsonProperty("fromAddr")]
        public string FromAddr { get; set; }

        /// <summary>
        /// toAddr string to address
        /// </summary>
        [JsonProperty("toAddr")]
        public string ToAddr { get; set; }

        /// <summary>
        /// value string value of transaction
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// txAsset     string
        /// </summary>
        [JsonProperty("txAsset")]
        public string TxAsset { get; set; }

        /// <summary>
        /// txFee   string
        /// </summary>
        [JsonProperty("txFee")]
        public string TxFee { get; set; }

        /// <summary>
        /// txAge   long
        /// </summary>
        [JsonProperty("txAge")]
        public long TxAge { get; set; }

        /// <summary>
        /// orderId     string order ID
        /// </summary>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// code    integer transaction result code 	0
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// data    string
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// confirmBlocks long
        /// </summary>
        [JsonProperty("confirmBlocks")]
        public long ConfirmBlocks { get; set; }
    }
}
