using EverscaleSdk.Modules.Boc.Models;

namespace EverscaleSdk.Modules.Abi.Models
{
	public struct ParamsOfEncodeInitialData
    {
        /// <summary>
        ///     Contract ABI.
        /// </summary>
        public Abi Abi { get; set; }

        /// <summary>
        ///     List of initial values for contract's static variables.
        ///     <see cref="Abi"/> parameter should be provided to set initial data.
        /// </summary>
        public dynamic? InitialData { get; set; }

        /// <summary>
        ///     Initial account owner's public key to set into account data.
        /// </summary>
        public string InitialPubkey { get; set; }

        /// <summary>
        ///     Cache type to put the result. The BOC itself returned if no cache type provided.
        /// </summary>
        public BocCacheType BocCache { get; set; }
    }
}

