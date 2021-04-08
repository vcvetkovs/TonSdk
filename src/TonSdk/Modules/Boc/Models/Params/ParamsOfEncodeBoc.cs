namespace TonSdk.Modules.Boc.Models
{
    public struct ParamsOfEncodeBoc
    {
        /// <summary>
        /// Cell builder operations.
        /// </summary>
        public BuilderOp[] Builder { get; set; }

        /// <summary>
        /// Cache type to put the result. The BOC itself returned if no cache type provided.
        /// </summary>
        public BocCacheType BocCache { get; set; }
    }
}
