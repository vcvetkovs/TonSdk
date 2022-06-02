namespace EverscaleSdk.Configs
{
    public struct ProofsConfig
    {
        /// <summary>
        ///     Cache proofs in the local storage.
        /// </summary>
        /// <remarks>
        ///     Default is `true`. <para/>
        ///     
        ///     If this value is set to `true`, downloaded proofs and master-chain BOCs are saved into the
        ///     persistent local storage (e.g. file system for native environments or browser's IndexedDB
        ///     for the web); otherwise all the data is cached only in memory in current client's context
        ///     and will be lost after destruction of the client.
        /// </remarks>
        public bool? CacheInLocalStorage { get; set; }
    }
}

