using System.Threading.Tasks;
using TonSdk.Modules.Boc.Models;

namespace TonSdk.Modules.Boc
{
    public class BocModule : IBocModule
    {
        private readonly ITonClient _client;

        public BocModule(ITonClient client)
        {
            _client = client;
        }

        public Task<ResultOfParse> ParseMessage(ParamsOfParse @params)
        {
            return _client
                .CallFunction<ResultOfParse>(Consts.Commands.ParseMessage, @params);
        }

        public Task<ResultOfParse> ParseTransaction(ParamsOfParse @params)
        {
            return _client
                .CallFunction<ResultOfParse>(Consts.Commands.ParseTransaction, @params);
        }

        public Task<ResultOfParse> ParseAccount(ParamsOfParse @params)
        {
            return _client
                .CallFunction<ResultOfParse>(Consts.Commands.ParseAccount, @params);
        }

        public Task<ResultOfParse> ParseBlock(ParamsOfParse @params)
        {
            return _client
                .CallFunction<ResultOfParse>(Consts.Commands.ParseBlock, @params);
        }

        public Task<ResultOfGetBlockchainConfig> GetBlockchainConfig(ParamsOfGetBlockchainConfig @params)
        {
            return _client
                .CallFunction<ResultOfGetBlockchainConfig>(Consts.Commands.GetBlockchainConfig, @params);
        }
    }
}
