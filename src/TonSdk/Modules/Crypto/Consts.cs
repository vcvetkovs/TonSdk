namespace TonSdk.Modules.Crypto
{
    public class Consts
    {
        public class Commands
        {
            public const string Factorize = "crypto.factorize";
            public const string ModularPower = "crypto.modular_power";
            public const string TonCrc16 = "crypto.ton_crc16";
            public const string GenerateRandomBytes = "crypto.generate_random_bytes";
            public const string ConvertPublicKeyToTonSafeFormat = "crypto.convert_public_key_to_ton_safe_format";
            public const string GenerateRandomSignKeys = "crypto.generate_random_sign_keys";
            public const string Sign = "crypto.sign";
            public const string VerifySignature = "crypto.verify_signature";
            public const string Sha256 = "crypto.sha256";
            public const string Sha512 = "crypto.sha512";
            public const string Scrypt = "crypto.scrypt";
            public const string NaclSignKeypairFromSecretKey = "crypto.nacl_sign_keypair_from_secret_key";
            public const string NaclSign = "crypto.nacl_sign";
            public const string NaclSignOpen = "crypto.nacl_sign_open";
            public const string NaclSignDetached = "crypto.nacl_sign_detached";
            public const string NaclBoxKeypair = "crypto.nacl_box_keypair";
            public const string NaclBoxKeypairFromSecretKey = "crypto.nacl_box_keypair_from_secret_key";
            public const string NaclBox = "crypto.nacl_box";
            public const string NaclBoxOpen = "crypto.nacl_box_open";
            public const string NaclSecretBox = "crypto.nacl_secret_box";
            public const string NaclSecretBoxOpen = "crypto.nacl_secret_box_open";
            public const string MnemonicWords = "crypto.mnemonic_words";
            public const string MnemonicFromRandom = "crypto.mnemonic_from_random";
            public const string MnemonicFromEntropy = "crypto.mnemonic_from_entropy";
            public const string MnemonicVerify = "crypto.mnemonic_verify";
            public const string MnemonicDeriveSignKeys = "crypto.mnemonic_derive_sign_keys";
            public const string HDKeyXPrvFromMnemonic = "crypto.hdkey_xprv_from_mnemonic";
            public const string HDKeyDeriveFromXPrv = "crypto.hdkey_derive_from_xprv";
            public const string HDKeyDeriveFromXPrvPath = "crypto.hdkey_derive_from_xprv_path";
            public const string HDKeySecretFromXPrv = "crypto.hdkey_secret_from_xprv";
            public const string HDKeyPublicFromXPrv = "crypto.hdkey_public_from_xprv";
            public const string Chacha20 = "crypto.chacha20";
            public const string RegisterSigningBox = "crypto.register_signing_box";
            public const string GetSigningBox = "crypto.get_signing_box";
            public const string SigningBoxGetPublicKey = "crypto.signing_box_get_public_key";
            public const string SigningBoxSign = "crypto.signing_box_sign";
            public const string RemoveSigningBox = "crypto.remove_signing_box";
        }
    }
}
