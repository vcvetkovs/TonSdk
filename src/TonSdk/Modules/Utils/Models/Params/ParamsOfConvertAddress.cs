namespace TonSdk.Modules.Utils.Models
{
    public struct ParamsOfConvertAddress
    {
        /// <summary>
        /// Account address in any TON format.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Specify the format to convert to.
        /// </summary>
        public AddressStringFormat OutputFormat { get; set; }
    }
}
