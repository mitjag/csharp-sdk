using binance.dex.sdk.websocket.stream;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket
{
    public interface IWebSocket
    {
        event EventHandler<IStreamData> StreamData;

        void Connect();
    }
}
