namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ParamsOfTonCrc16
    {
        /// <summary>
        ///     Input data for CRC calculation.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>base64</c>.
        /// </remarks>
        public string Data { get; set; }
    }
}
