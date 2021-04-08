namespace TonSdk.Modules.Boc.Models
{
    public struct ParamsOfBocCacheSet
    {
        /// <summary>
        /// BOC encoded as base64 or BOC reference
        /// </summary>
        public string Boc { get; set; }

        /// <summary>
        /// Cache type
        /// </summary>
        public BocCacheType CacheType { get; set; }
    }
}
