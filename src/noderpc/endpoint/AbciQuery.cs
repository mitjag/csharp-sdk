using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    public enum EAbciQueryPath
    {
        StoreAccKey, TokensInfo, TokensList, DexPairs, DexOrderbook, ParamFees
    }

    public class AbciQuery
    {
        public const string StoreAccKey = "/store/acc/key";
        public const string TokensInfo = "/tokens/info";
        public const string TokensList = "/tokens/list";
        public const string DexPairs = "/dex/pairs";
        public const string DexOrderbook = "/dex/orderbook";
        public const string ParamFees = "/param/fees";

        public static string ToAbciQueryPath(EAbciQueryPath abciQueryPath)
        {
            switch (abciQueryPath)
            {
                case EAbciQueryPath.StoreAccKey:
                    return StoreAccKey;
                case EAbciQueryPath.TokensInfo:
                    return TokensInfo;
                case EAbciQueryPath.TokensList:
                    return TokensList;
                case EAbciQueryPath.DexPairs:
                    return DexPairs;
                case EAbciQueryPath.DexOrderbook:
                    return DexOrderbook;
                case EAbciQueryPath.ParamFees:
                    return ParamFees;
                default:
                    throw new NodeRpcException($"Unhandled abciQueryPath: {abciQueryPath}");
            }
        }
    }

    /*
        Query the application for some information. Query Parameters
        Parameter 	Type 	Default 	Required 	Description
        path 	string 	false 	false 	Path to the data ("/a/b/c")
        data 	[]byte 	false 	true 	Data
        height 	int64 	0 	false 	Height (0 means latest)
        prove 	bool 	false 	false 	Includes proof if true

        Available Query Path /store/acc/key /tokens/info /tokens/list /dex/pairs /dex/orderbook /param/fees Return Type:

        type ResponseQuery struct {
            Code                 uint32
            Log                  string
            Info                 string
            Index                int64
            Key                  []byte
            Value                []byte
            Proof                *merkle.Proof
            Height               int64
            Codespace            string
        }
    */

    public class ResponseQuery
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("log")]
        public string Log { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("proof")]
        public string Proof { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("codespace")]
        public string Codespace { get; set; }
    }

    public class ResultAbciQuery : IEndpointResponse
    {
        [JsonProperty("response")]
        public ResponseQuery Response { get; set; }
    }
}
