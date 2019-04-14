using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.websocket
{
    public class ETopic
    {
        // Topic Name: orders | Stream: /ws/userAddress
        // Topic Name: accounts | Stream: /ws/userAddress
        // Topic Name: transfers | Stream: /ws/userAddress
        // Topic Name: trades | Stream: \<symbol>@trades
        // Topic Name: marketDiff | Stream: \<symbol>@marketDiff
        // Topic Name: marketDepth | Stream: \<symbol>@marketDepth
        // Topic Name: kline_\<interval> | Stream: \<symbol>@kline_\<interval>
        // Topic Name: ticker | Stream: \<symbol>@ticker
        // Topic Name: allTickers | Stream: $all@allTickers
        // Topic Name: miniTicker | Stream: \<symbol>@miniTicker
        // Topic Name: allMiniTickers | Stream: $all@allMiniTickers
        // Topic Name: blockheight | Stream: $all@blockheight
    }

    public class EStreams
    {
        /*
        Single streams may be accessed at /ws/\<streamName>
        Combined streams may be accessed at /stream?streams=\<streamName1>/\<streamName2>/\<streamName3> (etc.)

        // for personal streams, ex: Account & Orders & Transfers
        const accountAndOrdersFeeds = new WebSocket("wss://testnet-dex.binance.org/api/ws/<USER_ADDRESS>");

        // for single streams
        const tradesFeeds = new WebSocket("wss://testnet-dex.binance.org/api/ws/<symbol>@trades");
        const marketFeeds = new WebSocket("wss://testnet-dex.binance.org/api/ws/<symbol>@marketDiff");
        const deltaFeeds = new WebSocket("wss://testnet-dex.binance.org/api/ws/<symbol>@marketDepth");
  
        // for all symbols
        const allTickers = new WebSocket("wss://testnet-dex.binance.org/api/ws/$all@allTickers");
        const allMiniTickers = new WebSocket("wss://testnet-dex.binance.org/api/ws/$all@allMiniTickers");
        const blockHeight = new WebSocket("wss://testnet-dex.binance.org/api/ws/$all@blockheight");

        // for combined streams, can combined a mixed symbols and streams
        const combinedFeeds = new WebSocket("wss://testnet-dex.binance.org/api/stream?streams=<symbol>@trades/<symbol>@marketDepth/<symbol>@marketDiff");
        */
    }

    /*
     Note: Once the connection is established, websocket server would send ping frame to client every 30 seconds.
     Client should response pong frame in time (this has already implemented by most mordern browers,
     but programmatical users need be aware of whether your websocket library support this), otherwise,
     the connection might be closed.
    */

    public class WebSocketClient
    {

        /*
         * WebSocket Streams:
         * Orders
         * Account
         * Transfer
         * Trades
         * Diff. Depth Stream
         * Book Depth Streams
         * Kline/Candlestick Streams
         * Individual Symbol Ticker Streams
         * All Symbols Ticker Streams
         * Individual Symbol Mini Ticker Streams
         * All Symbols Mini Ticker Streams
         * Blockheight
         */



    }
}
