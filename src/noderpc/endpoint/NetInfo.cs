using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    /*
        * Get network info. Return Parameters
        *
        // Info about peer connections
        type ResultNetInfo struct {
            Listening bool     `json:"listening"`
            Listeners []string `json:"listeners"`
            NPeers    int      `json:"n_peers"`
            Peers     []Peer   `json:"peers"`
        }
    */

    /*
        {
            "jsonrpc": "2.0",
            "id": "",
            "result": {
            "listening": true,
            "listeners": [
                "Listener(@a0b88b324243a11e994280efee3352a7-96b6996626c6481d.elb.ap-northeast-1.amazonaws.com:27146)"
            ],
            "n_peers": "8",
            "peers": [
                {
                "node_info": {
                    "protocol_version": {
                    "p2p": "7",
                    "block": "10",
                    "app": "0"
                    },
                    "id": "8c379d4d3b9995c712665dc9a9414dbde5b30483",
                    "listen_addr": "aa1e4d0d1243a11e9a951063f6065739-7a82be90a58744b6.elb.ap-northeast-1.amazonaws.com:27146",
                    "network": "Binance-Chain-Nile",
                    "version": "0.30.1",
                    "channels": "354020212223303800",
                    "moniker": "data-seed-1",
                    "other": {
                    "tx_index": "on",
                    "rpc_address": "tcp://0.0.0.0:27147"
                    }
                },
                "is_outbound": false,
                "connection_status": {
                    "Duration": "642994282602700",
                    "SendMonitor": {
                    "Active": true,
                    "Start": "2019-04-16T11:39:42.12Z",
                    "Duration": "642994280000000",
                    "Idle": "120000000",
                    "Bytes": "10283221770",
                    "Samples": "4183358",
                    "InstRate": "32971",
                    "CurRate": "16666",
                    "AvgRate": "15993",
                    "PeakRate": "1004500",
                    "BytesRem": "0",
                    "TimeRem": "0",
                    "Progress": 0
                    },
                    "RecvMonitor": {
                    "Active": true,
                    "Start": "2019-04-16T11:39:42.12Z",
                    "Duration": "642994280000000",
                    "Idle": "120000000",
                    "Bytes": "10194868736",
                    "Samples": "4177227",
                    "InstRate": "35707",
                    "CurRate": "13825",
                    "AvgRate": "15855",
                    "PeakRate": "278633",
                    "BytesRem": "0",
                    "TimeRem": "0",
                    "Progress": 0
                    },
                    "Channels": [
                    {
                        "ID": 48,
                        "SendQueueCapacity": "1",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 53,
                        "SendQueueCapacity": "1000",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 64,
                        "SendQueueCapacity": "1000",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 32,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "13477"
                    },
                    {
                        "ID": 33,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "53759"
                    },
                    {
                        "ID": 34,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "67177"
                    },
                    {
                        "ID": 35,
                        "SendQueueCapacity": "2",
                        "SendQueueSize": "0",
                        "Priority": "1",
                        "RecentlySent": "86"
                    },
                    {
                        "ID": 56,
                        "SendQueueCapacity": "1",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 0,
                        "SendQueueCapacity": "10",
                        "SendQueueSize": "0",
                        "Priority": "1",
                        "RecentlySent": "0"
                    }
                    ]
                },
                "remote_ip": "10.201.43.250"
                },
                {
                "node_info": {
                    "protocol_version": {
                    "p2p": "7",
                    "block": "10",
                    "app": "0"
                    },
                    "id": "3c2b4071c486c2faed92f2b360aacea73415c08e",
                    "listen_addr": "10.201.41.94:27146",
                    "network": "Binance-Chain-Nile",
                    "version": "0.30.1",
                    "channels": "3540202122233038",
                    "moniker": "bridge",
                    "other": {
                    "tx_index": "on",
                    "rpc_address": "tcp://0.0.0.0:27147"
                    }
                },
                "is_outbound": true,
                "connection_status": {
                    "Duration": "157685284095639",
                    "SendMonitor": {
                    "Active": true,
                    "Start": "2019-04-22T02:28:11.12Z",
                    "Duration": "157685280000000",
                    "Idle": "120000000",
                    "Bytes": "563228441",
                    "Samples": "1021461",
                    "InstRate": "3336",
                    "CurRate": "3411",
                    "AvgRate": "3572",
                    "PeakRate": "85071",
                    "BytesRem": "0",
                    "TimeRem": "0",
                    "Progress": 0
                    },
                    "RecvMonitor": {
                    "Active": true,
                    "Start": "2019-04-22T02:28:11.12Z",
                    "Duration": "157685280000000",
                    "Idle": "120000000",
                    "Bytes": "3002515968",
                    "Samples": "1041900",
                    "InstRate": "44464",
                    "CurRate": "19792",
                    "AvgRate": "19041",
                    "PeakRate": "117990",
                    "BytesRem": "0",
                    "TimeRem": "0",
                    "Progress": 0
                    },
                    "Channels": [
                    {
                        "ID": 48,
                        "SendQueueCapacity": "1",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 53,
                        "SendQueueCapacity": "1000",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 64,
                        "SendQueueCapacity": "1000",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 32,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "15089"
                    },
                    {
                        "ID": 33,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "7142"
                    },
                    {
                        "ID": 34,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "10388"
                    },
                    {
                        "ID": 35,
                        "SendQueueCapacity": "2",
                        "SendQueueSize": "0",
                        "Priority": "1",
                        "RecentlySent": "116"
                    },
                    {
                        "ID": 56,
                        "SendQueueCapacity": "1",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 0,
                        "SendQueueCapacity": "10",
                        "SendQueueSize": "0",
                        "Priority": "1",
                        "RecentlySent": "0"
                    }
                    ]
                },
                "remote_ip": "10.201.41.94"
                },
                {
                "node_info": {
                    "protocol_version": {
                    "p2p": "7",
                    "block": "10",
                    "app": "0"
                    },
                    "id": "aea74b16d28d06cbfbb1179c177e8cd71315cce4",
                    "listen_addr": "ac6d84c3f243a11e98ced0ac108d49f7-704ea117aa391bbe.elb.ap-northeast-1.amazonaws.com:27146",
                    "network": "Binance-Chain-Nile",
                    "version": "0.30.1",
                    "channels": "354020212223303800",
                    "moniker": "seed",
                    "other": {
                    "tx_index": "on",
                    "rpc_address": "tcp://0.0.0.0:27147"
                    }
                },
                "is_outbound": true,
                "connection_status": {
                    "Duration": "643364825610161",
                    "SendMonitor": {
                    "Active": true,
                    "Start": "2019-04-16T11:33:31.58Z",
                    "Duration": "643364820000000",
                    "Idle": "120000000",
                    "Bytes": "12439507790",
                    "Samples": "4247865",
                    "InstRate": "44621",
                    "CurRate": "20063",
                    "AvgRate": "19335",
                    "PeakRate": "175190",
                    "BytesRem": "0",
                    "TimeRem": "0",
                    "Progress": 0
                    },
                    "RecvMonitor": {
                    "Active": true,
                    "Start": "2019-04-16T11:33:31.58Z",
                    "Duration": "643364820000000",
                    "Idle": "100000000",
                    "Bytes": "2260089816",
                    "Samples": "4256952",
                    "InstRate": "3708",
                    "CurRate": "1939",
                    "AvgRate": "3513",
                    "PeakRate": "193642",
                    "BytesRem": "0",
                    "TimeRem": "0",
                    "Progress": 0
                    },
                    "Channels": [
                    {
                        "ID": 48,
                        "SendQueueCapacity": "1",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 53,
                        "SendQueueCapacity": "1000",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 64,
                        "SendQueueCapacity": "1000",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 32,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "14343"
                    },
                    {
                        "ID": 33,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "57678"
                    },
                    {
                        "ID": 34,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "90126"
                    },
                    {
                        "ID": 35,
                        "SendQueueCapacity": "2",
                        "SendQueueSize": "0",
                        "Priority": "1",
                        "RecentlySent": "137"
                    },
                    {
                        "ID": 56,
                        "SendQueueCapacity": "1",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 0,
                        "SendQueueCapacity": "10",
                        "SendQueueSize": "0",
                        "Priority": "1",
                        "RecentlySent": "0"
                    }
                    ]
                },
                "remote_ip": "52.199.237.19"
                },
                {
                "node_info": {
                    "protocol_version": {
                    "p2p": "7",
                    "block": "10",
                    "app": "0"
                    },
                    "id": "7156d461742e2a1e569fd68426009c4194830c93",
                    "listen_addr": "aa841c226243a11e9a951063f6065739-eee556e439dc6a3b.elb.ap-northeast-1.amazonaws.com:27146",
                    "network": "Binance-Chain-Nile",
                    "version": "0.30.1",
                    "channels": "354020212223303800",
                    "moniker": "data-seed-2",
                    "other": {
                    "tx_index": "on",
                    "rpc_address": "tcp://0.0.0.0:27147"
                    }
                },
                "is_outbound": false,
                "connection_status": {
                    "Duration": "642941274295686",
                    "SendMonitor": {
                    "Active": true,
                    "Start": "2019-04-16T11:40:35.14Z",
                    "Duration": "642941260000000",
                    "Idle": "120000000",
                    "Bytes": "10374829269",
                    "Samples": "4183573",
                    "InstRate": "35879",
                    "CurRate": "16853",
                    "AvgRate": "16137",
                    "PeakRate": "507175",
                    "BytesRem": "0",
                    "TimeRem": "0",
                    "Progress": 0
                    },
                    "RecvMonitor": {
                    "Active": true,
                    "Start": "2019-04-16T11:40:35.14Z",
                    "Duration": "642941260000000",
                    "Idle": "120000000",
                    "Bytes": "10107331530",
                    "Samples": "4178210",
                    "InstRate": "35721",
                    "CurRate": "14804",
                    "AvgRate": "15720",
                    "PeakRate": "257320",
                    "BytesRem": "0",
                    "TimeRem": "0",
                    "Progress": 0
                    },
                    "Channels": [
                    {
                        "ID": 48,
                        "SendQueueCapacity": "1",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 53,
                        "SendQueueCapacity": "1000",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 64,
                        "SendQueueCapacity": "1000",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 32,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "15005"
                    },
                    {
                        "ID": 33,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "60234"
                    },
                    {
                        "ID": 34,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "76072"
                    },
                    {
                        "ID": 35,
                        "SendQueueCapacity": "2",
                        "SendQueueSize": "0",
                        "Priority": "1",
                        "RecentlySent": "162"
                    },
                    {
                        "ID": 56,
                        "SendQueueCapacity": "1",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 0,
                        "SendQueueCapacity": "10",
                        "SendQueueSize": "0",
                        "Priority": "1",
                        "RecentlySent": "56"
                    }
                    ]
                },
                "remote_ip": "10.201.43.94"
                },
                {
                "node_info": {
                    "protocol_version": {
                    "p2p": "7",
                    "block": "10",
                    "app": "0"
                    },
                    "id": "9b55d6c03e7e373e3e4d51e7ebf8d85c8fca0c20",
                    "listen_addr": "tcp://0.0.0.0:27146",
                    "network": "Binance-Chain-Nile",
                    "version": "0.30.1",
                    "channels": "3540202122233038",
                    "moniker": "BNB48 Club",
                    "other": {
                    "tx_index": "on",
                    "rpc_address": "tcp://0.0.0.0:27147"
                    }
                },
                "is_outbound": false,
                "connection_status": {
                    "Duration": "22848046769125",
                    "SendMonitor": {
                    "Active": true,
                    "Start": "2019-04-23T15:55:28.36Z",
                    "Duration": "22848040000000",
                    "Idle": "120000000",
                    "Bytes": "47052409",
                    "Samples": "148205",
                    "InstRate": "3336",
                    "CurRate": "1740",
                    "AvgRate": "2059",
                    "PeakRate": "1759820",
                    "BytesRem": "0",
                    "TimeRem": "0",
                    "Progress": 0
                    },
                    "RecvMonitor": {
                    "Active": true,
                    "Start": "2019-04-23T15:55:28.36Z",
                    "Duration": "22848040000000",
                    "Idle": "6580000000",
                    "Bytes": "123350",
                    "Samples": "8179",
                    "InstRate": "0",
                    "CurRate": "0",
                    "AvgRate": "5",
                    "PeakRate": "14400",
                    "BytesRem": "0",
                    "TimeRem": "0",
                    "Progress": 0
                    },
                    "Channels": [
                    {
                        "ID": 48,
                        "SendQueueCapacity": "1",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 53,
                        "SendQueueCapacity": "1000",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 64,
                        "SendQueueCapacity": "1000",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "2152"
                    },
                    {
                        "ID": 32,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "12919"
                    },
                    {
                        "ID": 33,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 34,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 35,
                        "SendQueueCapacity": "2",
                        "SendQueueSize": "0",
                        "Priority": "1",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 56,
                        "SendQueueCapacity": "1",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 0,
                        "SendQueueCapacity": "10",
                        "SendQueueSize": "0",
                        "Priority": "1",
                        "RecentlySent": "0"
                    }
                    ]
                },
                "remote_ip": "10.201.42.129"
                },
                {
                "node_info": {
                    "protocol_version": {
                    "p2p": "7",
                    "block": "10",
                    "app": "0"
                    },
                    "id": "84ad762f4cdaad6942325dadf12f045c4e10d29a",
                    "listen_addr": "10.201.41.248:27146",
                    "network": "Binance-Chain-Nile",
                    "version": "0.30.1",
                    "channels": "3540202122233038",
                    "moniker": "bridge",
                    "other": {
                    "tx_index": "on",
                    "rpc_address": "tcp://0.0.0.0:27147"
                    }
                },
                "is_outbound": true,
                "connection_status": {
                    "Duration": "157644462008364",
                    "SendMonitor": {
                    "Active": true,
                    "Start": "2019-04-22T02:28:51.94Z",
                    "Duration": "157644460000000",
                    "Idle": "120000000",
                    "Bytes": "482958352",
                    "Samples": "1021068",
                    "InstRate": "34421",
                    "CurRate": "5934",
                    "AvgRate": "3064",
                    "PeakRate": "85071",
                    "BytesRem": "0",
                    "TimeRem": "0",
                    "Progress": 0
                    },
                    "RecvMonitor": {
                    "Active": true,
                    "Start": "2019-04-22T02:28:51.94Z",
                    "Duration": "157644460000000",
                    "Idle": "120000000",
                    "Bytes": "3001618969",
                    "Samples": "1038773",
                    "InstRate": "44464",
                    "CurRate": "19928",
                    "AvgRate": "19040",
                    "PeakRate": "141870",
                    "BytesRem": "0",
                    "TimeRem": "0",
                    "Progress": 0
                    },
                    "Channels": [
                    {
                        "ID": 48,
                        "SendQueueCapacity": "1",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 53,
                        "SendQueueCapacity": "1000",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 64,
                        "SendQueueCapacity": "1000",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 32,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "13766"
                    },
                    {
                        "ID": 33,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "5249"
                    },
                    {
                        "ID": 34,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "6063"
                    },
                    {
                        "ID": 35,
                        "SendQueueCapacity": "2",
                        "SendQueueSize": "0",
                        "Priority": "1",
                        "RecentlySent": "141"
                    },
                    {
                        "ID": 56,
                        "SendQueueCapacity": "1",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 0,
                        "SendQueueCapacity": "10",
                        "SendQueueSize": "0",
                        "Priority": "1",
                        "RecentlySent": "0"
                    }
                    ]
                },
                "remote_ip": "10.201.41.248"
                },
                {
                "node_info": {
                    "protocol_version": {
                    "p2p": "7",
                    "block": "10",
                    "app": "0"
                    },
                    "id": "b4126f460ecb22e70f1374c4fd492a48a6cbd43b",
                    "listen_addr": "tcp://127.0.0.1:26656",
                    "network": "Binance-Chain-Nile",
                    "version": "0.30.1",
                    "channels": "354020212223303800",
                    "moniker": "xxx",
                    "other": {
                    "tx_index": "on",
                    "rpc_address": "tcp://127.0.0.1:26657"
                    }
                },
                "is_outbound": false,
                "connection_status": {
                    "Duration": "3241319668505",
                    "SendMonitor": {
                    "Active": true,
                    "Start": "2019-04-23T21:22:15.08Z",
                    "Duration": "3241320000000",
                    "Idle": "60000000",
                    "Bytes": "46916348",
                    "Samples": "22106",
                    "InstRate": "71621",
                    "CurRate": "15240",
                    "AvgRate": "14474",
                    "PeakRate": "178790",
                    "BytesRem": "0",
                    "TimeRem": "0",
                    "Progress": 0
                    },
                    "RecvMonitor": {
                    "Active": true,
                    "Start": "2019-04-23T21:22:15.08Z",
                    "Duration": "3241320000000",
                    "Idle": "60000000",
                    "Bytes": "11547939",
                    "Samples": "11248",
                    "InstRate": "37080",
                    "CurRate": "9670",
                    "AvgRate": "3563",
                    "PeakRate": "151860",
                    "BytesRem": "0",
                    "TimeRem": "0",
                    "Progress": 0
                    },
                    "Channels": [
                    {
                        "ID": 48,
                        "SendQueueCapacity": "1",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 53,
                        "SendQueueCapacity": "1000",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 64,
                        "SendQueueCapacity": "1000",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 32,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "15204"
                    },
                    {
                        "ID": 33,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "38811"
                    },
                    {
                        "ID": 34,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "43235"
                    },
                    {
                        "ID": 35,
                        "SendQueueCapacity": "2",
                        "SendQueueSize": "0",
                        "Priority": "1",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 56,
                        "SendQueueCapacity": "1",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 0,
                        "SendQueueCapacity": "10",
                        "SendQueueSize": "0",
                        "Priority": "1",
                        "RecentlySent": "1"
                    }
                    ]
                },
                "remote_ip": "10.201.43.54"
                },
                {
                "node_info": {
                    "protocol_version": {
                    "p2p": "7",
                    "block": "10",
                    "app": "0"
                    },
                    "id": "18da4bda7f31e2b967d70d60d427ea2905d19a17",
                    "listen_addr": "tcp://0.0.0.0:27146",
                    "network": "Binance-Chain-Nile",
                    "version": "0.30.1",
                    "channels": "354020212223303800",
                    "moniker": "xxx",
                    "other": {
                    "tx_index": "on",
                    "rpc_address": "tcp://0.0.0.0:27147"
                    }
                },
                "is_outbound": false,
                "connection_status": {
                    "Duration": "1490430253780",
                    "SendMonitor": {
                    "Active": true,
                    "Start": "2019-04-23T21:51:25.98Z",
                    "Duration": "1490420000000",
                    "Idle": "60000000",
                    "Bytes": "35780557",
                    "Samples": "10594",
                    "InstRate": "60714",
                    "CurRate": "26170",
                    "AvgRate": "24007",
                    "PeakRate": "112400",
                    "BytesRem": "0",
                    "TimeRem": "0",
                    "Progress": 0
                    },
                    "RecvMonitor": {
                    "Active": true,
                    "Start": "2019-04-23T21:51:25.98Z",
                    "Duration": "1490420000000",
                    "Idle": "80000000",
                    "Bytes": "4001267",
                    "Samples": "9511",
                    "InstRate": "950",
                    "CurRate": "1567",
                    "AvgRate": "2685",
                    "PeakRate": "41450",
                    "BytesRem": "0",
                    "TimeRem": "0",
                    "Progress": 0
                    },
                    "Channels": [
                    {
                        "ID": 48,
                        "SendQueueCapacity": "1",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 53,
                        "SendQueueCapacity": "1000",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 64,
                        "SendQueueCapacity": "1000",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 32,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "13767"
                    },
                    {
                        "ID": 33,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "10",
                        "RecentlySent": "61189"
                    },
                    {
                        "ID": 34,
                        "SendQueueCapacity": "100",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "129277"
                    },
                    {
                        "ID": 35,
                        "SendQueueCapacity": "2",
                        "SendQueueSize": "0",
                        "Priority": "1",
                        "RecentlySent": "2"
                    },
                    {
                        "ID": 56,
                        "SendQueueCapacity": "1",
                        "SendQueueSize": "0",
                        "Priority": "5",
                        "RecentlySent": "0"
                    },
                    {
                        "ID": 0,
                        "SendQueueCapacity": "10",
                        "SendQueueSize": "0",
                        "Priority": "1",
                        "RecentlySent": "0"
                    }
                    ]
                },
                "remote_ip": "10.201.43.38"
                }
            ]
            }
        }
    */

    public class NodeInfoProtocolVersion
    {
        [JsonProperty("p2p")]
        public string p2p { get; set; }

        [JsonProperty("block")]
        public string Block { get; set; }

        [JsonProperty("app")]
        public string App { get; set; }
    }

    public class NodeInfoOther
    {
        [JsonProperty("tx_index")]
        public string TxIndex { get; set; }

        [JsonProperty("rpc_address")]
        public string RpcAddress { get; set; }
    }

    public class NodeInfo
    {
        [JsonProperty("protocol_version")]
        public NodeInfoProtocolVersion ProtocolVersion { get; set; }

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
        public NodeInfoOther Other { get; set; }
    }

    public class NetInfoPeerConnectionStatusMonitor
    {
        [JsonProperty("Active")]
        public bool Active { get; set; }

        [JsonProperty("Start")]
        public string Start { get; set; }

        [JsonProperty("Duration")]
        public string Duration { get; set; }

        [JsonProperty("Idle")]
        public string Idle { get; set; }

        [JsonProperty("Bytes")]
        public string Bytes { get; set; }

        [JsonProperty("Samples")]
        public string Samples { get; set; }

        [JsonProperty("InstRate")]
        public string InstRate { get; set; }

        [JsonProperty("CurRate")]
        public string CurRate { get; set; }

        [JsonProperty("AvgRate")]
        public string AvgRate { get; set; }

        [JsonProperty("PeakRate")]
        public string PeakRate { get; set; }

        [JsonProperty("BytesRem")]
        public string BytesRem { get; set; }

        [JsonProperty("TimeRem")]
        public string TimeRem { get; set; }

        [JsonProperty("Progress")]
        public int Progress { get; set; }
    }

    public class NetInfoPeerConnectionStatusChannel
    {
        [JsonProperty("ID")]
        public long ID { get; set; }

        [JsonProperty("SendQueueCapacity")]
        public string SendQueueCapacity { get; set; }

        [JsonProperty("SendQueueSize")]
        public string SendQueueSize { get; set; }

        [JsonProperty("Priority")]
        public string Priority { get; set; }

        [JsonProperty("RecentlySent")]
        public string RecentlySent { get; set; }
    }

    public class NetInfoPeerConnectionStatus
    {
        [JsonProperty("Duration")]
        public string Duration { get; set; }

        [JsonProperty("SendMonitor")]
        public NetInfoPeerConnectionStatusMonitor SendMonitor { get; set; }

        [JsonProperty("RecvMonitor")]
        public NetInfoPeerConnectionStatusMonitor RecvMonitor { get; set; }

        [JsonProperty("Channels")]
        public List<NetInfoPeerConnectionStatusChannel> Channels { get; set; }
    }

    public class NetInfoPeer
    {
        [JsonProperty("node_info")]
        public NodeInfo NodeInfo { get; set; }

        [JsonProperty("is_outbound")]
        public bool IsOutbound { get; set; }

        [JsonProperty("connection_status")]
        public NetInfoPeerConnectionStatus ConnectionStatus { get; set; }

        [JsonProperty("remote_ip")]
        public string RemoteIp { get; set; }
    }

    public class ResultNetInfo : IEndpointResponse
    {
        [JsonProperty("listening")]
        public bool Listening { get; set; }

        [JsonProperty("listeners")]
        public List<string> Listeners { get; set; }

        [JsonProperty("n_peers")]
        public string NPeers { get; set; }

        [JsonProperty("peers")]
        public List<NetInfoPeer> Peers { get; set; }
    }
}
