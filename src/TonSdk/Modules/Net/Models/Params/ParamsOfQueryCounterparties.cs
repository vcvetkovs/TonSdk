namespace TonSdk.Modules.Net.Models
{
    public struct ParamsOfQueryCounterparties
    {
        /// <summary>
        ///     Account address.
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        ///     Projection (result) string.
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        ///     Number of counterparties to return.
        /// </summary>
        public uint? First { get; set; }

        /// <summary>
        ///     `cursor` field of the last received result.
        /// </summary>
        public string After { get; set; }
    }
}
