using System.Threading.Tasks;
using TonSdk.Modules.Boc.Models;

namespace TonSdk.Modules.Boc
{
    /// <summary>
    /// BOC manipulation module.
    /// </summary>
    public interface IBocModule
    {
        /// <summary>
        /// Parses message boc into a JSON
        /// 
        /// JSON structure is compatible with GraphQL API message object
        /// </summary>
        public Task<ResultOfParse> ParseMessage(ParamsOfParse @params);

        /// <summary>
        /// Parses transaction boc into a JSON
        ///
        /// JSON structure is compatible with GraphQL API transaction object
        /// </summary>
        public Task<ResultOfParse> ParseTransaction(ParamsOfParse @params);

        /// <summary>
        /// Parses account boc into a JSON
        /// 
        /// JSON structure is compatible with GraphQL API account object
        /// </summary>
        Task<ResultOfParse> ParseAccount(ParamsOfParse @params);

        /// <summary>
        /// Parses block boc into a JSON
        /// 
        /// JSON structure is compatible with GraphQL API block object
        /// </summary>
        Task<ResultOfParse> ParseBlock(ParamsOfParse @params);

        Task<ResultOfGetBlockchainConfig> GetBlockchainConfig(ParamsOfGetBlockchainConfig @params);
    }
}
