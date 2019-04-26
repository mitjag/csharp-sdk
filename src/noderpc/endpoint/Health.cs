using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
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
