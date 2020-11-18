namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfHash
    {
        /// <summary>
        /// Input data for hash calculation. Encoded with `base64`.
        /// </summary>
        public string Data { get; set; }
    }
}
