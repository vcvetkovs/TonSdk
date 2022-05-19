namespace TonSdk.Modules.Crypto.Models
{
	public struct ResultOfGetCryptoBoxSeedPhrase
    {
        public string Phrase { get; set; }

        public byte Dictionary { get; set; }

        public byte Wordcount { get; set; }
    }
}

