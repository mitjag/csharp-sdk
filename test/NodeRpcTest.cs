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
        private const string endpoint = "https://data-seed-pre-0-s1.binance.org";

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
            NodeRpcClient nodeRpcClient = new NodeRpcClient(endpoint);
            ResponseData responseData = nodeRpcClient.AbciInfo();
            Assert.NotNull(responseData.Response.Data);
        }

        [Fact]
        public void ConsensusStateTest()
        {
            NodeRpcClient nodeRpcClient = new NodeRpcClient(endpoint);
            ConsensusRoundStateData result = nodeRpcClient.ConsensusState();
            Assert.NotNull(result.RoundState.HeightVoteSets[0]);
        }

        [Fact]
        public void DumpConsensusStateTest()
        {
            NodeRpcClient nodeRpcClient = new NodeRpcClient(endpoint);
            DumpRoundStateData result = nodeRpcClient.DumpConsensusState();
            Assert.NotNull(result.RoundState.Height);
        }

        [Fact]
        public void NetInfoTest()
        {
            NodeRpcClient nodeRpcClient = new NodeRpcClient(endpoint);
            ResultNetInfo result = nodeRpcClient.NetInfo();
            Assert.NotNull(result.Peers[0].NodeInfo.Id);
        }

        [Fact]
        public void GenesisTest()
        {
            NodeRpcClient nodeRpcClient = new NodeRpcClient(endpoint);
            ResultGenesis result = nodeRpcClient.Genesis();
            Assert.NotNull(result.Genesis);
        }

        [Fact]
        public void HealthTest()
        {
            NodeRpcClient nodeRpcClient = new NodeRpcClient(endpoint);
            ResultHealth result = nodeRpcClient.Health();
            Assert.NotNull(result);
        }

        /*[Fact]
        public void NodeRpcExceptionTest()
        {
            NodeRpcClient nodeRpcClient = new NodeRpcClient(endpoint);
            ResultUnconfirmedTxs result;
            Assert.Throws<NodeRpcException>(() => result = nodeRpcClient.NumUnconfirmedTxs());
        }*/

        [Fact]
        public void NumUnconfirmedTxsTest()
        {
            NodeRpcClient nodeRpcClient = new NodeRpcClient(endpoint);
            ResultUnconfirmedTxs result = nodeRpcClient.NumUnconfirmedTxs();
            Assert.NotNull(result.NTxs);
        }

        [Fact]
        public void StatusTest()
        {
            NodeRpcClient nodeRpcClient = new NodeRpcClient(endpoint);
            ResultStatus result = nodeRpcClient.Status();
            Assert.NotNull(result.NodeInfo.ListenAddr);
        }
    }
}
