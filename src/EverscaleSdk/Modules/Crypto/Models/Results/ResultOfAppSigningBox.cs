namespace EverscaleSdk.Modules.Crypto.Models.Results
{
	/// <summary>
	///     Returning values from signing box callbacks.
	/// </summary>
	public abstract class ResultOfAppSigningBox
    {
        /// <summary>
        ///     Result of getting public key.
        /// </summary>
        public class GetPublicKey : ResultOfAppSigningBox
        {
            /// <summary>
            ///     Signing box public key.
            /// </summary>
            public string PublicKey { get; set; }
        }

        /// <summary>
        ///     Result of signing data.
        /// </summary>
        public class Sign : ResultOfAppSigningBox
        {
            /// <summary>
            ///     Data signature encoded as hex.
            /// </summary>
            public string Signature { get; set; }
        }
    }
}
