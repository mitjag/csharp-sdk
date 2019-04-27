using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.noderpc
{
    public class NodeRpcException : Exception
    {
        public Error Error { get; }

        public NodeRpcException(String message) : base(message)
        {
        }

        public NodeRpcException(String message, Error error) : base(message)
        {
            Error = error;
        }

        public NodeRpcException(String message, Exception innerException, Error error) : base(message, innerException)
        {
            Error = error;
        }
    }
}
