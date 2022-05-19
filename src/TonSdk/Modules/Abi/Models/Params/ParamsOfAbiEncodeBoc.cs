using TonSdk.Modules.Boc.Models;

namespace TonSdk.Modules.Abi.Models
{
	public struct ParamsOfAbiEncodeBoc
    {
        /// <summary>
        ///     Parameters to encode into BOC.
        /// </summary>
        public AbiParameter[] Params { get; set; }

        /// <summary>
        ///     Parameters and values as a JSON structure.
        /// </summary>
        public dynamic? Data { get; set; }

        /// <summary>
        ///     Cache type to put the result.
        ///     The BOC itself returned if no cache type provided.
        /// </summary>
        public BocCacheType BocCache { get; set; }
    }
}

