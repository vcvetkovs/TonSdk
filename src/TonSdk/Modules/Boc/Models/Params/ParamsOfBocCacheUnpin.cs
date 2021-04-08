namespace TonSdk.Modules.Boc.Models
{
    public struct ParamsOfBocCacheUnpin
    {
        /// <summary>
        /// Pinned name
        /// </summary>
        public string Pin { get; set; }

        /// <summary>
        /// <para>Reference to the cached BOC.</para>
        /// <para>If it is provided then only referenced BOC is unpinned</para>
        /// </summary>
        public string BocRef { get; set; }
    }
}
