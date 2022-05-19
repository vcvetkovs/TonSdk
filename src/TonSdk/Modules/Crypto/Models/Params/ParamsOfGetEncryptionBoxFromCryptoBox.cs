namespace TonSdk.Modules.Crypto.Models
{
	public struct ParamsOfGetEncryptionBoxFromCryptoBox
    {
        /// <summary>
        ///     Crypto Box Handle.
        /// </summary>
        public uint Handle { get; set; }

        /// <summary>
        ///     HD key derivation path.
        /// </summary>
        /// <remarks>
        ///     By default, Everscale HD path is used.
        /// </remarks>
        public string Hdpath { get; set; }

        /// <summary>
        ///     Encryption algorithm.
        /// </summary>
        public BoxEncryptionAlgorithm Algorithm { get; set; }

        /// <summary>
        ///     Store derived secret for encryption algorithm for this lifetime
        ///     (in ms). The timer starts after each encryption box operation.
        ///     Secrets will be deleted (overwritten with zeroes) after each
        ///     encryption operation, if this value is not set.
        /// </summary>
        public uint? SecretLifetime { get; set; }

    }
}

