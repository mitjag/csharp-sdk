using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class Peer
    {
        /// <summary>
        /// id string Authenticated identifier 	8c379d4d3b9995c712665dc9a9414dbde5b30483
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// original_listen_addr    string (RemoteAddr) Original listen address before PeersService changed it
        /// </summary>
        [JsonProperty("original_listen_addr")]
        public string OriginalListenAddress;

        /// <summary>
        /// listen_addr string (RemoteAddr) Listen address
        /// </summary>
        [JsonProperty("listen_addr")]
        public string ListenAddress { get; set; }

        /// <summary>
        /// access_addr     string (RemoteAddr) Access address(HTTP)
        /// </summary>
        [JsonProperty("access_addr")]
        public string AccessAddress { get; set; }

        /// <summary>
        /// stream_addr string (RemoteAddr) Stream address(WS)
        /// </summary>
        [JsonProperty("stream_addr")]
        public string StreamAddress { get; set; }

        /// <summary>
        /// network string Chain ID Binance-Chain-Nile
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <summary>
        /// version     string Version 	0.30.1
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// moniker string Moniker(Name)  data-seed-1
        /// </summary>
        [JsonProperty("moniker")]
        public string Moniker { get; set; }

        /// <summary>
        /// capabilities[string] Array of capability tags: node, qs, ap, ws node, ap
        /// </summary>
        [JsonProperty("capabilities")]
        public List<string> Capabilities { get; set; }

        /// <summary>
        /// accelerated 	boolean 	Is an accelerated path to a validator node
        /// </summary>
        [JsonProperty("accelerated")]
        public bool Accelerated { get; set; }
    }
}
