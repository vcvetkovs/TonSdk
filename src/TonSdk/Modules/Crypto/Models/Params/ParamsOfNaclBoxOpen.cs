﻿namespace TonSdk.Modules.Crypto.Models
{
    public struct ParamsOfNaclBoxOpen
    {
        /// <summary>
        /// Data that must be decrypted. Encoded with `base64`.
        /// </summary>
        public string Encrypted { get; set; }

        public string Nonce { get; set; }

        /// <summary>
        /// Sender's public key - unprefixed 0-padded to 64 symbols hex string.
        /// </summary>
        public string TheirPublic { get; set; }

        /// <summary>
        /// Receiver's private key - unprefixed 0-padded to 64 symbols hex string.
        /// </summary>
        public string Secret { get; set; }
    }
}
