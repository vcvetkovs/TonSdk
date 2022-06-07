using System.Threading.Tasks;
using EverscaleSdk.Configs;
using EverscaleSdk.Modules.Client.Models;

namespace EverscaleSdk.Modules.Client
{
    /// <summary>
    ///     Provides information about library.
    /// </summary>
    public interface IClientModule
    {
        /// <summary>
        ///     Returns Core Library API reference.
        /// </summary>
        Task<ResultOfGetApiReference> GetApiReference();

        /// <summary>
        ///     Returns Core Library version.
        /// </summary>
        Task<ResultOfVersion> Version();

        /// <summary>
        ///     Returns detailed information about this build.
        /// </summary>
        Task<ResultOfBuildInfo> BuildInfo();

        /// <summary>
        ///     Resolves application request processing result.
        /// </summary>
        Task ResolveAppRequest(ParamsOfResolveAppRequest @params);

        /// <summary>
        ///     Returns Core Library API reference.
        /// </summary>
        Task<ClientConfig> Config();
    }
}
