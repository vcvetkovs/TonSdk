namespace EverscaleSdk.Modules.Crypto.Models
{
	public struct ParamsOfGetSigningBoxFromCryptoBox
    {
        /// <summary>
        ///     Crypto Box Handle.
        /// </summary>
        public uint Handle { get; set; }

        /// <summary>
        ///     HD key derivation path.
        ///     By default, Everscale HD path is used.
        /// </summary>
        public string Hdpath { get; set; }

        /// <summary>
        ///     Store derived secret for this lifetime (in ms).
        ///     The timer starts after each signing box operation.
        ///     Secrets will be deleted immediately after each signing box
        ///     operation, if this value is not set.
        /// </summary>
        public uint? SecretLifetime { get; set; }
    }
}

