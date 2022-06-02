namespace EverscaleSdk.Configs
{
	public struct BocConfig
    {
        /// <summary>
        ///     Maximum BOC cache size in kilobytes.
        /// </summary>
        /// <remarks>
        ///     Default is 10 MB.
        /// </remarks>
        public uint? CacheMaxSize { get; set; }
    }
}
