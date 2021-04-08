namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfConvertPublicKeyToTonSafeFormat
    {
        /// <summary>
        /// Must be encoded with `base64`.
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Must be encoded with `hex`.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Must be encoded with `hex`.
        /// </summary>
        public string Nonce { get; set; }
    }
}
