namespace EverscaleSdk.Modules.Crypto.Models
{
	/// <summary>
	///     Signing box callbacks.
	/// </summary>
	public abstract class ParamsOfAppSigningBox
    {
        /// <summary>
        ///     Get signing box public key.
        /// </summary>
        public class GetPublicKey : ParamsOfAppSigningBox
        {
        }

        /// <summary>
        ///     Sign data.
        /// </summary>
        public class Sign : ParamsOfAppSigningBox
        {
            /// <summary>
            ///     Data to sign encoded as base64.
            /// </summary>
            public string Unsigned { get; set; }
        }
    }

}
