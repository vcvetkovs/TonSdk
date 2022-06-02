namespace EverscaleSdk.Configs
{
    public struct AbiConfig
    {
        /// <summary>
        ///     Workchain id that is used by default in DeploySet.
        /// </summary>
        public int? Workchain { get; set; }

        /// <summary>
        ///     Message lifetime for contracts which ABI includes "expire" header.
        /// </summary>
        /// <remarks>
        ///     The default value is 40 sec.
        /// </remarks>
        public uint? MessageExpirationTimeout { get; set; }

        /// <summary>
        ///     Factor that increases the expiration timeout for each retry.
        /// </summary>
        /// <remarks>
        ///     The default value is 1.5.
        /// </remarks>
        public float? MessageExpirationTimeoutGrowFactor { get; set; }
    }
}
