namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ParamsOfNaclSign
    {
        /// <summary>
        ///     Data that must be signed encoded in <c>base64</c>.
        /// </summary>
        public string Unsigned { get; set; }

        /// <summary>
        ///     Signer's secret key - unprefixed 0-padded to 128 symbols hex string
        ///     (concatenation of 64 symbols secret and 64 symbols public keys). <para/>
        ///     
        ///     See <see cref="ICryptoModule.NaclSignKeypairFromSecretKey(ParamsOfNaclSignKeyPairFromSecret)"/>
        /// </summary>
        public string Secret { get; set; }
    }
}
