using System.Threading.Tasks;
using TonSdk.Modules.Client.Models;

namespace TonSdk.Modules.Client
{
    public class ClientModule : IClientModule
    {
        private readonly ITonClient _client;

        public ClientModule(ITonClient client)
        {
            _client = client;
        }

        public Task<ResultOfGetApiReference> GetApiReference()
        {
            return _client
                .CallFunction<ResultOfGetApiReference>(Consts.Commands.GetApiReference);
        }

        public Task<ResultOfVersion> Version()
        {
            return _client
                .CallFunction<ResultOfVersion>(Consts.Commands.Version);
        }

        public Task<ResultOfBuildInfo> BuildInfo()
        {
            return _client
                .CallFunction<ResultOfBuildInfo>(Consts.Commands.BuildInfo);
        }

        public Task ResolveAppRequest(ParamsOfResolveAppRequest @params)
        {
            return _client
                .CallFunction(Consts.Commands.ResolveAppRequest);
        }
    }
}
