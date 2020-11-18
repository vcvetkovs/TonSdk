namespace TonSdk.Modules.Abi.Models
{
    public struct ParamsOfDecodeMessage
    {
        /// <summary>
        /// Contract ABI.
        /// </summary>
        public Abi Abi { get; set; }

        /// <summary>
        /// Message BOC.
        /// </summary>
        public string Message { get; set; }
    }
}
