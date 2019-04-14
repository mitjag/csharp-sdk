Binance DEX C# SDK
==================

Source code is under MIT License (MIT)

C# SDK is inspired by Binance DEX Java SDK, (used a lot in previous Binance DEX "competition")

Project uses following NuGet packages:

    NBitcoin
    Google.Protobuf
    RestSharp
    WebsocketRPC.Standalone

SDK supports:
    Creating Wallets
    Creating Signature
    Broadcast to Binance DEX chain
    HTTP API
    WebSockets

Example how to transfer founds:
Transfer 

``` cs
    HttpApiClient httpApiClient = new HttpApiClient(BinanceDexEnvironment.TEST_NET);
    Wallet wallet = new Wallet(
        "6d3cfc67595db1523915219718a31fa5b467d099a51035d8fb82ea9841496f09",
        BinanceDexEnvironment.TEST_NET);

    Transfer transfer = new Transfer
    {
        Coin = "PND-943",
        FromAddress = wallet.Address,
        ToAddress = "tbnb18086qc9yxtk5ufddple8upf0k3072vvagpm2ml",
        Amount = "0.05"
    };

    TransactionRequest assmebler = new TransactionRequest(wallet, TransactionOption.DefaultInstace);
    string body = assmebler.BuildTransfer(transfer);
    List<TransactionMetadata> result = httpApiClient.Broadcast(body);
```
