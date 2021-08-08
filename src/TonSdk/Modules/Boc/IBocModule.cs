using System.Threading.Tasks;
using TonSdk.Modules.Boc.Models;

namespace TonSdk.Modules.Boc
{
    /// <summary>
    ///     BOC manipulation module.
    /// </summary>
    public interface IBocModule
    {
        /// <summary>
        ///     Parses message boc into a JSON.
        /// </summary>
        /// <remarks>
        ///     JSON structure is compatible with GraphQL API message object.
        /// </remarks>
        public Task<ResultOfParse> ParseMessage(ParamsOfParse @params);

        /// <summary>
        ///     Parses transaction boc into a JSON.
        /// </summary>
        /// <remarks>
        ///     JSON structure is compatible with GraphQL API message object.
        /// </remarks>
        public Task<ResultOfParse> ParseTransaction(ParamsOfParse @params);

        /// <summary>
        ///     Parses account boc into a JSON.
        /// </summary>
        /// <remarks>
        ///     JSON structure is compatible with GraphQL API message object.
        /// </remarks>
        public Task<ResultOfParse> ParseAccount(ParamsOfParse @params);

        /// <summary>
        ///     Parses block boc into a JSON.
        /// </summary>
        /// <remarks>
        ///     JSON structure is compatible with GraphQL API message object.
        /// </remarks>
        public Task<ResultOfParse> ParseBlock(ParamsOfParse @params);

        /// <summary>
        ///     Parses shardstate boc into a JSON.
        /// </summary>
        /// <remarks>
        ///     JSON structure is compatible with GraphQL API shardstate object.
        /// </remarks>
        public Task<ResultOfParse> ParseShardstate(ParamsOfParseShardState @params);

        /// <summary>
        ///     Extract blockchain configuration from key block and also from zerostate.
        /// </summary>
        public Task<ResultOfGetBlockchainConfig> GetBlockchainConfig(ParamsOfGetBlockchainConfig @params);

        /// <summary>
        ///     Calculates BOC root hash.
        /// </summary>
        public Task<ResultOfGetBocHash> GetBocHash(ParamsOfGetBocHash @params);

        /// <summary>
        ///     Extracts code from TVC contract image.
        /// </summary>
        public Task<ResultOfGetCodeFromTvc> GetCodeFromTvc(ParamsOfGetCodeFromTvc @params);

        /// <summary>
        ///     Get BOC from cache.
        /// </summary>
        public Task<ResultOfBocCacheGet> CacheGet(ParamsOfBocCacheGet @params);

        /// <summary>
        ///     Save BOC into cache.
        /// </summary>
        public Task<ResultOfBocCacheSet> CacheSet(ParamsOfBocCacheSet @params);

        /// <summary>
        ///     Unpin BOCs with specified pin. <para/>
        ///     
        ///     BOCs which don't have another pins will be removed from cache.
        /// </summary>
        public Task CacheUnpin(ParamsOfBocCacheUnpin @params);

        /// <summary>
        ///     Encodes BOC from builder operations.
        /// </summary>
        public Task<ResultOfEncodeBoc> EncodeBoc(ParamsOfEncodeBoc @params);
    }
}
