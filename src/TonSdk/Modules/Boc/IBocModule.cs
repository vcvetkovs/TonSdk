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
        /// <para>Parses message boc into a JSON</para>
        /// <para>JSON structure is compatible with GraphQL API message object</para>
        /// </summary>
        public Task<ResultOfParse> ParseMessage(ParamsOfParse @params);

        /// <summary>
        /// <para>Parses transaction boc into a JSON</para>
        /// <para>JSON structure is compatible with GraphQL API transaction object</para>
        /// </summary>
        public Task<ResultOfParse> ParseTransaction(ParamsOfParse @params);

        /// <summary>
        /// <para>Parses account boc into a JSON</para>
        /// <para>JSON structure is compatible with GraphQL API account object</para>
        /// </summary>
        public Task<ResultOfParse> ParseAccount(ParamsOfParse @params);

        /// <summary>
        /// <para>Parses block boc into a JSON</para>
        /// <para>JSON structure is compatible with GraphQL API block object</para>
        /// </summary>
        public Task<ResultOfParse> ParseBlock(ParamsOfParse @params);

        /// <summary>
        /// <para>Parses shardstate boc into a JSON</para>
        /// <para>JSON structure is compatible with GraphQL API shardstate object</para>
        /// </summary>
        public Task<ResultOfParse> ParseShardstate(ParamsOfParseShardState @params);

        /// <summary>
        /// Extract blockchain configuration from key block and also from zerostate.
        /// </summary>
        public Task<ResultOfGetBlockchainConfig> GetBlockchainConfig(ParamsOfGetBlockchainConfig @params);

        /// <summary>
        /// Calculates BOC root hash
        /// </summary>
        public Task<ResultOfGetBocHash> GetBocHash(ParamsOfGetBocHash @params);

        /// <summary>
        /// Extracts code from TVC contract image
        /// </summary>
        public Task<ResultOfGetCodeFromTvc> GetCodeFromTvc(ParamsOfGetCodeFromTvc @params);

        /// <summary>
        /// Get BOC from cache
        /// </summary>
        public Task<ResultOfBocCacheGet> CacheGet(ParamsOfBocCacheGet @params);

        /// <summary>
        /// Save BOC into cache
        /// </summary>
        public Task<ResultOfBocCacheSet> CacheSet(ParamsOfBocCacheSet @params);

        /// <summary>
        /// <para>Unpin BOCs with specified pin.</para>
        /// <para>BOCs which don't have another pins will be removed from cache</para>
        /// </summary>
        public Task CacheUnpin(ParamsOfBocCacheUnpin @params);

        /// <summary>
        /// Encodes BOC from builder operations.
        /// </summary>
        public Task<ResultOfEncodeBoc> EncodeBoc(ParamsOfEncodeBoc @params);
    }
}
