using binance.dex.sdk.noderpc;
using binance.dex.sdk.noderpc.endpoint;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace binance.dex.sdk.test
{
    public class NodeRpcTest
    {
        [Fact]
        public void JsonTest()
        {
            string test = "{\n  \"jsonrpc\": \"2.0\",\n  \"id\": \"abci_info-1\",\n  \"result\": {\n    \"response\": {\n      \"data\": \"BNBChain\",\n      \"last_block_height\": \"9701248\",\n      \"last_block_app_hash\": \"LH9gA62y7QiJFa2HieBsMttoLuyTNI+wWQT4BOf80XY=\"\n    }\n  }\n}";
            RpcResponse<ResponseData> rpcResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<RpcResponse<ResponseData>>(test);
            Assert.NotNull(rpcResponse.Result);
        }

        [Fact]
        public void AbciInfoTest()
        {
            NodeRpcClient nodeRpcClient = new NodeRpcClient("https://data-seed-pre-0-s1.binance.org");
            ResponseData responseData = nodeRpcClient.AbcInfo();
            Assert.NotNull(responseData.Response.Data);
        }
    }
}
