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
        Task<ResultOfParse> ParseMessage(ParamsOfParse @params);

        /// <summary>
        ///     Parses transaction boc into a JSON.
        /// </summary>
        /// <remarks>
        ///     JSON structure is compatible with GraphQL API message object.
        /// </remarks>
        Task<ResultOfParse> ParseTransaction(ParamsOfParse @params);

        /// <summary>
        ///     Parses account boc into a JSON.
        /// </summary>
        /// <remarks>
        ///     JSON structure is compatible with GraphQL API message object.
        /// </remarks>
        Task<ResultOfParse> ParseAccount(ParamsOfParse @params);

        /// <summary>
        ///     Parses block boc into a JSON.
        /// </summary>
        /// <remarks>
        ///     JSON structure is compatible with GraphQL API message object.
        /// </remarks>
        Task<ResultOfParse> ParseBlock(ParamsOfParse @params);

        /// <summary>
        ///     Parses shardstate boc into a JSON.
        /// </summary>
        /// <remarks>
        ///     JSON structure is compatible with GraphQL API shardstate object.
        /// </remarks>
        Task<ResultOfParse> ParseShardstate(ParamsOfParseShardState @params);

        /// <summary>
        ///     Extract blockchain configuration from key block and also from zerostate.
        /// </summary>
        Task<ResultOfGetBlockchainConfig> GetBlockchainConfig(ParamsOfGetBlockchainConfig @params);

        /// <summary>
        ///     Calculates BOC root hash.
        /// </summary>
        Task<ResultOfGetBocHash> GetBocHash(ParamsOfGetBocHash @params);

        /// <summary>
        ///     Calculates BOC depth.
        /// </summary>
        Task<ResultOfGetBocDepth> GetBocDepth(ParamsOfGetBocDepth @params);

        /// <summary>
        ///     Extracts code from TVC contract image.
        /// </summary>
        Task<ResultOfGetCodeFromTvc> GetCodeFromTvc(ParamsOfGetCodeFromTvc @params);

        /// <summary>
        ///     Get BOC from cache.
        /// </summary>
        Task<ResultOfBocCacheGet> CacheGet(ParamsOfBocCacheGet @params);

        /// <summary>
        ///     Save BOC into cache.
        /// </summary>
        Task<ResultOfBocCacheSet> CacheSet(ParamsOfBocCacheSet @params);

        /// <summary>
        ///     Unpin BOCs with specified pin.
        /// </summary>
        /// <remarks>
        ///     BOCs which don't have another pins will be removed from cache.
        /// </remarks>
        Task CacheUnpin(ParamsOfBocCacheUnpin @params);

        /// <summary>
        ///     Encodes BOC from builder operations.
        /// </summary>
        /// <remarks>
        ///     Encodes bag of cells (BOC) with builder operations.
        ///     This method provides the same functionality as
        ///     Solidity TvmBuilder. <para />
        ///     
        ///     Resulting BOC of this method can be passed into
        ///     Solidity and C++ contracts as TvmCell type.
        /// </remarks>
        Task<ResultOfEncodeBoc> EncodeBoc(ParamsOfEncodeBoc @params);

        /// <summary>
        ///     Returns the contract code's salt if it is present.
        /// </summary>
        Task<ResultOfGetCodeSalt> GetCodeSalt(ParamsOfGetCodeSalt @params);

        /// <summary>
        ///     Returns the new contract code with salt.
        /// </summary>
        Task<ResultOfSetCodeSalt> SetCodeSalt(ParamsOfSetCodeSalt @params);

        /// <summary>
        ///     Decodes tvc into code, data, libraries and special options.
        /// </summary>
        Task<ResultOfDecodeTvc> DecodeTvc(ParamsOfDecodeTvc @params);

        /// <summary>
        ///     Encodes tvc from code, data, libraries ans special options (see input params)
        /// </summary>
        Task<ResultOfEncodeTvc> EncodeTvc(ParamsOfEncodeTvc @params);

        /// <summary>
        ///     Returns the compiler version used to compile the code.
        /// </summary>
        Task<ResultOfGetCompilerVersion> GetCompilerVersion(ParamsOfGetCompilerVersion @params);

        /// <summary>
        ///     Encodes a message.
        ///     Allows to encode any external inbound message.
        /// </summary>
        Task<ResultOfEncodeExternalInMessage> EncodeExternalInMessage(ParamsOfEncodeExternalInMessage @params);
    }
}
