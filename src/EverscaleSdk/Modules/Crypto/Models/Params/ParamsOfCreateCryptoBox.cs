namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ParamsOfCreateCryptoBox
    {
        /// <summary>
        ///     Salt used for secret encryption.
        ///     For example, a mobile device can use device ID as salt.
        /// </summary>
        public string SecretEncryptionSalt { get; set; }

        /// <summary>
        ///     Cryptobox secret.
        /// </summary>
        public CryptoBoxSecret Secret { get; set; }
    }
}

