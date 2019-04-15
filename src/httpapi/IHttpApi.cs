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

        Transaction Tx(string hash, bool raw = true);

        List<Token> Tokens(int limit = 500, int offset = 0);

        List<Market> Markets(int limit = 500, int offset = 0);

        List<FeeData> Fees();

        MarketDepth Depth(string symbol, int limit = 5);

        List<TransactionMetadata> Broadcast(string body, bool sync = true);

        List<List<object>> KLines(string symbol, string interval, int limit = 300, long? startTime = null, long? endTime = null);

        //List<TransactionMetadata> Transfer(Transfer transfer);
    }
}
