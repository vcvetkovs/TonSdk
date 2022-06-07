using System.Threading.Tasks;
using EverscaleSdk.Configs;
using EverscaleSdk.Modules.Client.Models;

namespace EverscaleSdk.Modules.Client
{
    public class ClientModule : IClientModule
    {
        private readonly IEverscaleClient _client;

        public ClientModule(IEverscaleClient client)
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

        public Task<ClientConfig> Config()
        {
            return _client
                .CallFunction<ClientConfig>(Consts.Commands.Config);
        }
    }
}
