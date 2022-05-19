namespace TonSdk.Modules.Crypto.Models
{
    public struct BoxEncryptionAlgorithm
    {
        public ChaCha20ParamsCB ChaCha20 { get; set; }

        public NaclBoxParamsCB NaclBox { get; set; }
        
        public NaclSecretBoxParamsCB NaclSecretBox { get; set; }
    }
}

