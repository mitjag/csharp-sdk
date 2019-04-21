using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc
{
    public class NodeRpcException : Exception
    {
        public NodeRpcException(String message) : base(message)
        {
        }

        public NodeRpcException(String message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
