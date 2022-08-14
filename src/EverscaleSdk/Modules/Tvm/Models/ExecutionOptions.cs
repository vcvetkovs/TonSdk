namespace EverscaleSdk.Modules.Tvm.Models
{
    public struct ExecutionOptions
    {
        /// <summary>
        ///     BOC with config.
        /// </summary>
        public string? BlockchainConfig { get; set; }

        /// <summary>
        ///     Time that is used as transaction time
        /// </summary>
        public uint? BlockTime { get; set; }

        /// <summary>
        ///     Block logical time.
        /// </summary>
        public ulong? BlockLt { get; set; }

        /// <summary>
        ///     Transaction logical time.
        /// </summary>
        public ulong? TransactionLt { get; set; }

        /// <summary>
        ///     Overrides standard TVM behaviour.
        /// </summary>
        /// <remarks>
        ///     If set to <see langword="true"/>
        ///     then CHKSIG always will return <see langword="true"/>.
        /// </remarks>
        public bool? ChksigAlwaysSucceed { get; set; }
    }
}
