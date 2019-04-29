using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc.endpoint
{
    /*
        BroadcastTxAsync

        This method just return transaction hash right away and there is no return from CheckTx or DeliverTx. Transaction Parameters
        Parameter 	Type 	Default 	Required 	Description
        tx 	Tx 	nil 	true 	The transaction info bytes in hex

        Return Parameters Checktx Result

        type ResultBroadcastTx struct {
            Code uint32      
            Data cmn.HexBytes 
            Log  string      
            Hash cmn.HexBytes 
        }
    */

    /*
        {
            "error": "",
            "result": {
                "hash": "721B67C1772EA5FC7E80D70DEAA3C52034204FC60C057FF1117EE45468C1A980",
                "log": "",
                "data": "",
                "code": "0"
            },
            "id": "",
            "jsonrpc": "2.0"

        }
    */
}
