using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    public class HealthRequest
    {
        public static RpcRequest Request()
        {
            return new RpcRequest
            {
                Method = "health",
                JsonRpc = "2.0"
            };
        }
    }

    /*
        The above command returns JSON structured like this:
        {
            "error": "",
            "result": {},
            "id": "",
            "jsonrpc": "2.0"
        }
    */

    public class ResultHealth : IEndpointResponse
    {
    }
}
