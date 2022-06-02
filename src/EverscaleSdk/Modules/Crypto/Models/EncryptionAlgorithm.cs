namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct EncryptionAlgorithm
    {
        public AesParamsEB AES { get; set; }

        public ChaCha20ParamsEB ChaCha20 { get; set; }

        public NaclBoxParamsEB NaclBox { get; set; }

        public NaclSecretBoxParamsEB NaclSecretBox { get; set; }
    }
}
