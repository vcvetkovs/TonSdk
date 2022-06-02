namespace EverscaleSdk.Modules.Boc.Models
{
    public struct ParamsOfBocCacheUnpin
    {
        /// <summary>
        ///     Pinned name.
        /// </summary>
        public string Pin { get; set; }

        /// <summary>
        ///     Reference to the cached BOC.
        /// </summary>
        /// <remarks>
        ///     If it is provided then only referenced BOC is unpinned.
        /// </remarks>
        public string BocRef { get; set; }
    }
}
