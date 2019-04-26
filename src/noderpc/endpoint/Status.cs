using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    /*
        Get Tendermint status including node info, pubkey, latest block hash, app hash, block height and time. Return Parameters

        // Node Status
        type ResultStatus struct {
            NodeInfo      p2p.DefaultNodeInfo 
            SyncInfo      SyncInfo            
            ValidatorInfo ValidatorInfo      
        }
    */

    /*
        {
          "jsonrpc": "2.0",
          "id": "",
          "result": {
            "node_info": {
              "protocol_version": {
                "p2p": "7",
                "block": "10",
                "app": "0"
              },
              "id": "9612b570bffebecca4776cb4512d08e252119005",
              "listen_addr": "a0b88b324243a11e994280efee3352a7-96b6996626c6481d.elb.ap-northeast-1.amazonaws.com:27146",
              "network": "Binance-Chain-Nile",
              "version": "0.30.1",
              "channels": "354020212223303800",
              "moniker": "data-seed-0",
              "other": {
                "tx_index": "on",
                "rpc_address": "tcp://0.0.0.0:27147"
              }
            },
            "sync_info": {
              "latest_block_hash": "54FB027459C040C39F63CDFDAC044CC31478D804342EB2ACF6048AC9D8C040E0",
              "latest_app_hash": "A3187832E10DA9A255B927C83BCCAE843EE942AA65875AFBE2863D22FBA82A22",
              "latest_block_height": "10668268",
              "latest_block_time": "2019-04-25T19:17:13.339974535Z",
              "catching_up": false
            },
            "validator_info": {
              "address": "E44C14E60CE7D88752B2B144B164DFF2A20AA1D0",
              "pub_key": {
                "type": "tendermint/PubKeyEd25519",
                "value": "sbWMMKiniIxJunFq466D4yJAfmeQHuzP0PyX5FbHKKE="
              },
              "voting_power": "0"
            }
          }
        }
    */

    public class ResultStatusSyncInfo
    {
        [JsonProperty("latest_block_hash")]
        public string LatestBlockHash { get; set; }

        [JsonProperty("latest_app_hash")]
        public string LatestAppHash { get; set; }

        [JsonProperty("latest_block_height")]
        public string LatestBlockHeight { get; set; }

        [JsonProperty("latest_block_time")]
        public string LatestBlockTime { get; set; }

        [JsonProperty("catching_up")]
        public bool CatchingUp { get; set; }
    }

    public class ResultStatusValidatorInfo
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("pub_key")]
        public PubKey PubKey { get; set; }

        [JsonProperty("voting_power")]
        public string VotingPower { get; set; }
    }

    public class ResultStatus : IEndpointResponse
    {
        [JsonProperty("node_info")]
        public NodeInfo NodeInfo { get; set; }

        [JsonProperty("sync_info")]
        public ResultStatusSyncInfo SyncInfo { get; set; }

        [JsonProperty("validator_info")]
        public ResultStatusValidatorInfo ValidatorInfo { get; set; }
    }
}
