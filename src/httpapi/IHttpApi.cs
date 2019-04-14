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

        Infos NodeInfo();

        ValidatorInfo Validators();

        List<Peer> Peers();

        Account Account(string address);

        AccountSequence AccountSequence(string address);

        List<TransactionMetadata> Broadcast(string body, bool sync);
        //List<TransactionMetadata> Transfer(Transfer transfer);
    }
}
