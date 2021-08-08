﻿namespace TonSdk.Modules.Crypto.Models
{

    /// <summary>
    ///     Encryption box callbacks.
    /// </summary>
    public abstract class ParamsOfAppEncryptionBox
    {
        /// <summary>
        ///     Get encryption box info.
        /// </summary>
        public class GetInfo : ParamsOfAppEncryptionBox
        {
        }

        /// <summary>
        ///     Encrypt data.
        /// </summary>
        public class Encrypt : ParamsOfAppEncryptionBox
        {
            /// <summary>
            ///     Data, encoded in Base64.
            /// </summary>
            public string Data { get; set; }
        }

        /// <summary>
        ///     Decrypt data.
        /// </summary>
        public class Decrypt : ParamsOfAppEncryptionBox
        {
            /// <summary>
            ///     Data, encoded in Base64.
            /// </summary>
            public string Data { get; set; }
        }
    }
}
