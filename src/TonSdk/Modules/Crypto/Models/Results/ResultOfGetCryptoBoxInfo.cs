namespace TonSdk.Modules.Crypto.Models
{
	public struct ResultOfGetCryptoBoxInfo
    {
        /// <summary>
        ///     Secret (seed phrase) encrypted with salt and password.
        /// </summary>
        public string EncryptedSecret { get; set; }
    }
}

