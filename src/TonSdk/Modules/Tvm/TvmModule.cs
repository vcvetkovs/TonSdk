using System.Threading.Tasks;
using TonSdk.Modules.Tvm.Models;

namespace TonSdk.Modules.Tvm
{
    public class TvmModule : ITvmModule
    {
        private readonly ITonClient _client;

        public TvmModule(ITonClient client)
        {
            _client = client;
        }

        public Task<ResultOfRunExecutor> RunExecutor<AbiType>(ParamsOfRunExecutor<AbiType> @params)
        {
            return _client.CallFunction<ResultOfRunExecutor>(
                Consts.Commands.RunExecutor,
                @params);
        }

        public Task<ResultOfRunTvm> RunTvm<AbiType>(ParamsOfRunTvm<AbiType> @params)
        {
            return _client.CallFunction<ResultOfRunTvm>(
                Consts.Commands.RunTvm,
                @params);
        }

        public Task<ResultOfRunGet> RunGet(ParamsOfRunGet @params)
        {
            return _client.CallFunction<ResultOfRunGet>(
                Consts.Commands.RunGet,
                @params);
        }
    }
}
