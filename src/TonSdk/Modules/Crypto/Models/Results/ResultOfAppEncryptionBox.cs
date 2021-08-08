namespace TonSdk.Modules.Crypto.Models
{
    /// <summary>
    ///     Returning values from signing box callbacks.
    /// </summary>
    public abstract class ResultOfAppEncryptionBox
    {
        /// <summary>
        ///     Result of getting encryption box info.
        /// </summary>
        public class GetInfo : ResultOfAppEncryptionBox
        {
            public EncryptionBoxInfo Info { get; set; }
        }

        /// <summary>
        ///     Result of encrypting data.
        /// </summary>
        public class Encrypt : ResultOfAppEncryptionBox
        {
            /// <summary>
            ///     Encrypted data, encoded in Base64.
            /// </summary>
            public string Data { get; set; }
        }

        /// <summary>
        ///     Result of decrypting data.
        /// </summary>
        public class Decrypt : ResultOfAppEncryptionBox
        {
            /// <summary>
            ///     Decrypted data, encoded in Base64.
            /// </summary>
            public string Data { get; set; }
        }
    }

}
