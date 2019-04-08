using binance.dex.sdk.broadcast;
using binance.dex.sdk.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.httpapi
{
    public interface IHttpApi
    {
        Times Time();

        //List<TransactionMetadata> Transfer(Transfer transfer);

        List<TransactionMetadata> Broadcast(string body);
    }
}
