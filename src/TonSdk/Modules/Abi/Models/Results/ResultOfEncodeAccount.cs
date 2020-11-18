namespace TonSdk.Modules.Abi.Models
{
    public struct ResultOfEncodeAccount
    {
        /// <summary>
        /// Account BOC encoded in `base64`.
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Account ID  encoded in `hex`.
        /// </summary>
        public string Id { get; set; }
    }
}
