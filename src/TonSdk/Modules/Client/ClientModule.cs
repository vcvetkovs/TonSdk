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

        /// <summary>
        /// Returns Core Library API reference.
        /// </summary>
        public Task<ResultOfGetApiReference> GetApiReference()
        {
            return _client
                .CallFunction<ResultOfGetApiReference>(Consts.Commands.GetApiReference);
        }

        /// <summary>
        /// Returns Core Library version.
        /// </summary>
        public Task<ResultOfVersion> GetVersion()
        {
            return _client
                .CallFunction<ResultOfVersion>(Consts.Commands.Version);
        }

        public Task<ResultOfBuildInfo> GetBuildInfo()
        {
            return _client
                .CallFunction<ResultOfBuildInfo>(Consts.Commands.BuildInfo);
        }
    }
}
