using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.model
{
    public class NodeInfo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("listen_addr")]
        public string ListenAddr { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("channels")]
        public string Channels { get; set; }

        [JsonProperty("moniker")]
        public string Moniker { get; set; }

        [JsonProperty("other")]
        public Dictionary<string, object> Other { get; set; }
    }

    public class SyncInfo
    {
        [JsonProperty("latest_block_hash")]
        public string LatestBlockHash { get; set; }

        [JsonProperty("latest_app_hash")]
        public string LatestAppHash { get; set; }

        [JsonProperty("latest_block_height")]
        public long LatestBlockHeight { get; set; }

        [JsonProperty("latest_block_time")]
        public DateTime LatestBlockTime { get; set; }

        [JsonProperty("catching_up")]
        public bool CatchingUp { get; set; }
    }

    public class Infos
    {
        [JsonProperty("node_info")]
        public NodeInfo NodeInfo { get; set; }

        [JsonProperty("sync_info")]
        public SyncInfo SyncInfo { get; set; }

        [JsonProperty("validator_info")]
        public ValidatorInfo ValidatorInfo { get; set; }
    }
}
