using System.Threading.Tasks;
using TonSdk.Modules.Client.Models;

namespace TonSdk.Modules.Client
{
    /// <summary>
    /// Provides information about library.
    /// </summary>
    public interface IClientModule
    {
        /// <summary>
        /// Returns Core Library API reference.
        /// </summary>
        Task<ResultOfGetApiReference> GetApiReference();

        /// <summary>
        /// Returns Core Library version.
        /// </summary>
        public Task<ResultOfVersion> GetVersion();

        public Task<ResultOfBuildInfo> GetBuildInfo();
    }
}
