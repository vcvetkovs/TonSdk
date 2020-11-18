namespace TonSdk.Modules.Abi.Enums
{
    public enum SignerType
    {
        /// <summary>
        /// No keys are provided. Creates an unsigned message.
        /// </summary>
        None,

        /// <summary>
        /// Only public key is provided to generate unsigned message and `data_to_sign`
        /// which can be signed later.  
        /// </summary>
        External,

        /// <summary>
        /// Key pair is provided for signing.
        /// </summary>
        Keys,

        /// <summary>
        /// Signing Box interface is provided for signing, allows Dapps to sign messages using external APIs,
        /// such as HSM, cold wallet, etc.
        /// </summary>
        SigningBox
    }
}
