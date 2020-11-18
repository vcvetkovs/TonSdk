namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfTonCrc16
    {
        /// <summary>
        /// Input data for CRC calculation.
        /// Encoded with `base64`.
        /// </summary>
        public string Data { get; set; }
    }
}
