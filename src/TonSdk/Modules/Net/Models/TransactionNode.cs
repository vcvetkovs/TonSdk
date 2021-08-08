namespace TonSdk.Modules.Net.Models
{
    public struct TransactionNode
    {
        /// <summary>
        ///     Transaction id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     In message id.
        /// </summary>
        public string InMsg { get; set; }

        /// <summary>
        ///     Out message ids.
        /// </summary>
        public string[] OutMsgs { get; set; }

        /// <summary>
        ///     Account address.
        /// </summary>
        public string AccountAddr { get; set; }

        /// <summary>
        ///     Transactions total fees.
        /// </summary>
        public string TotalFees { get; set; }

        /// <summary>
        ///     Aborted flag.
        /// </summary>
        public bool Aborted { get; set; }

        /// <summary>
        ///     Compute phase exit code.
        /// </summary>
        public uint? ExitCode { get; set; }
    }
}
