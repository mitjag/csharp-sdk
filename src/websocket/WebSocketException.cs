using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket
{
    public class WebSocketException : Exception
    {
        public WebSocketException(String message) : base(message)
        {
        }

        public WebSocketException(String message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
