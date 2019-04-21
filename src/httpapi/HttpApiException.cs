using binance.dex.sdk.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.httpapi
{
    public class HttpApiException : Exception
    {
        public Error Error { get; }

        public HttpApiException(String message, Exception innerException) : base(message, innerException)
        {
        }

        public HttpApiException(String message, Exception innerException, Error error) : base(message, innerException)
        {
            Error = error;
        }
    }
}
