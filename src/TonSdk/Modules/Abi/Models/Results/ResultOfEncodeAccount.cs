namespace TonSdk.Modules.Abi.Models
{
    public struct ResultOfEncodeAccount
    {
        /// <summary>
        ///     Account BOC encoded in <c>base64</c>.
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        ///     Account ID  encoded in <c>hex</c>.
        /// </summary>
        public string Id { get; set; }
    }
}
