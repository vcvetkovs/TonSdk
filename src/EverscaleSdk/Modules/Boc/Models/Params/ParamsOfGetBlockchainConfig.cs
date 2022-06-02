namespace EverscaleSdk.Modules.Boc.Models
{
    public struct ParamsOfGetBlockchainConfig
    {
        /// <summary>
        ///     Key block BOC or zerostate BOC encoded as base64.
        /// </summary>
        public string BlockBoc { get; set; }
    }
}
