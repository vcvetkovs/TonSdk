using System.Threading.Tasks;
using EverscaleSdk.Modules.Tvm.Models;

namespace EverscaleSdk.Modules.Tvm
{
    public class TvmModule : ITvmModule
    {
        private readonly IEverscaleClient _client;

        public TvmModule(IEverscaleClient client)
        {
            _client = client;
        }

        public Task<ResultOfRunExecutor> RunExecutor(ParamsOfRunExecutor @params)
        {
            return _client.CallFunction<ResultOfRunExecutor>(
                Consts.Commands.RunExecutor,
                @params);
        }

        public Task<ResultOfRunTvm> RunTvm(ParamsOfRunTvm @params)
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
