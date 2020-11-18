using System.Threading.Tasks;
using TonSdk.Modules.Crypto.Models;

namespace TonSdk.Modules.Crypto
{
    /// <summary>
    /// Crypto functions.
    /// </summary>
    public interface ICryptoModule
    {
        /// <summary>
        /// Integer factorization.
        /// 
        /// <para>
        /// Performs prime factorization – decomposition of a composite number
        /// into a product of smaller prime integers (factors).
        /// </para>
        /// 
        /// See [https://en.wikipedia.org/wiki/Integer_factorization]
        /// </summary>
        Task<ResultOfFactorize> Factorize(ParamsOfFactorize @params);

        /// <summary>
        /// Modular exponentiation.
        /// 
        /// <para>
        /// Performs modular exponentiation for big integers (`base`^`exponent` mod `modulus`).
        /// </para>
        /// 
        /// See [https://en.wikipedia.org/wiki/Modular_exponentiation]
        /// </summary>
        Task<ResultOfModularPower> ModularPower(ParamsOfModularPower @params);

        /// <summary>
        /// Calculates CRC16 using TON algorithm.
        /// </summary>
        Task<ResultOfTonCrc16> TonCrc16(ParamsOfTonCrc16 @params);

        /// <summary>
        /// Generates random byte array of the specified length and returns it in `base64` format.
        /// </summary>
        Task<ResultOfGenerateRandomBytes> GenerateRandomBytes(
            ParamsOfGenerateRandomBytes @params);

        /// <summary>
        /// Converts public key to ton safe_format.
        /// </summary>
        Task<ResultOfConvertPublicKeyToTonSafeFormat> ConvertPublicKeyToTonSafeFormat(
            ParamsOfConvertPublicKeyToTonSafeFormat @params);

        /// <summary>
        /// Generates random ed25519 key pair.
        /// </summary>
        Task<KeyPair> GenerateRandomSignKeys();

        /// <summary>
        /// Signs a data using the provided keys.
        /// </summary>
        Task<ResultOfSign> Sign(ParamsOfSign @params);

        /// <summary>
        /// Verifies signed data using the provided public key.
        /// Raises error if verification is failed.
        /// </summary>
        public Task<ResultOfVerifySignature> VerifySignature(ParamsOfVerifySignature @params);

        /// <summary>
        /// Calculates SHA256 hash of the specified data.
        /// </summary>
        public Task<ResultOfHash> Sha256(ParamsOfHash @params);

        /// <summary>
        /// Calculates SHA512 hash of the specified data.
        /// </summary>
        public Task<ResultOfHash> Sha512(ParamsOfHash @params);

        /// <summary>
        /// Perform `scrypt` encryption.
        /// 
        /// <para>
        /// Derives key from `password` and `key` using `scrypt` algorithm.
        /// </para>
        /// 
        /// See [https://en.wikipedia.org/wiki/Scrypt].
        /// 
        /// <para>
        /// # Arguments
        ///  - `log_n` - The log2 of the Scrypt parameter `N`
        ///  - `r` - The Scrypt parameter `r`
        ///  - `p` - The Scrypt parameter `p`
        /// </para>
        /// <para>
        /// # Conditions
        ///  - `log_n` must be less than `64`
        ///  - `r` must be greater than `0` and less than or equal to `4294967295`
        ///  - `p` must be greater than `0` and less than `4294967295`
        /// </para>
        /// <para>
        /// # Recommended values sufficient for most use-cases:
        ///  - `log_n = 15` (`n = 32768`)
        ///  - `r = 8`
        ///  - `p = 1`
        /// </para>
        /// </summary>
        public Task<ResultOfScrypt> Scrypt(ParamsOfScrypt @params);

        /// <summary>
        /// Generates a key pair for signing from the secret key.
        /// </summary>
        public Task<KeyPair> NaclSignKeypairFromSecretKey(ParamsOfNaclSignKeyPairFromSecret @params);

        /// <summary>
        /// Signs data using the signer's secret key.
        /// </summary>
        public Task<ResultOfNaclSign> NaclSign(ParamsOfNaclSign @params);

        public Task<ResultOfNaclSignOpen> NaclSignOpen(ParamsOfNaclSignOpen @params);

        public Task<ResultOfNaclSignDetached> NaclSignDetached(ParamsOfNaclSign @params);

        public Task<KeyPair> NaclBoxKeypair();

        /// <summary>
        /// Generates key pair from a secret key.
        /// </summary>
        public Task<KeyPair> NaclBoxKeypairFromSecretKey(ParamsOfNaclBoxKeyPairFromSecret @params);

        /// <summary>
        /// Public key authenticated encryption
        /// 
        /// <para>
        /// Encrypt and authenticate a message using the senders secret key, the recievers public
        /// key, and a nonce. 
        /// </para>
        /// </summary>
        public Task<ResultOfNaclBox> NaclBox(ParamsOfNaclBox @params);

        /// <summary>
        /// Decrypt and verify the cipher text using the recievers secret key, the senders public
        /// key, and the nonce.
        /// </summary>
        public Task<ResultOfNaclBoxOpen> NaclBoxOpen(ParamsOfNaclBoxOpen @params);

        /// <summary>
        /// Encrypt and authenticate message using nonce and secret key.
        /// </summary>
        public Task<ResultOfNaclBox> NaclSecretBox(ParamsOfNaclSecretBox @params);

        /// <summary>
        /// Decrypts and verifies cipher text using `nonce` and secret `key`.
        /// </summary>
        public Task<ResultOfNaclBoxOpen> NaclSecretBoxOpen(ParamsOfNaclSecretBoxOpen @params);

        /// <summary>
        /// Prints the list of words from the specified dictionary.
        /// </summary>
        public Task<ResultOfMnemonicWords> MnemonicWords(ParamsOfMnemonicWords @params);

        /// <summary>
        /// Generates a random mnemonic from the specified dictionary and word count
        /// </summary>
        public Task<ResultOfMnemonicFromRandom> MnemonicFromRandom(ParamsOfMnemonicFromRandom @params);

        /// <summary>
        /// Generates mnemonic from pre-generated entropy.
        /// </summary>
        public Task<ResultOfMnemonicFromEntropy> MnemonicFromEntropy(ParamsOfMnemonicFromEntropy @params);

        /// <summary>
        /// Validates a mnemonic phrase.
        /// 
        /// <para>
        /// The phrase supplied will be checked for word length and validated according to the checksum
        /// specified in BIP0039.
        /// </para>
        /// </summary>
        public Task<ResultOfMnemonicVerify> MnemonicVerify(ParamsOfMnemonicVerify @params);

        /// <summary>
        /// Derives a key pair for signing from the seed phrase.
        /// 
        /// <para>
        /// Validates the seed phrase, generates master key and then derives
        /// the key pair from the master key and the specified path.
        /// </para>
        /// </summary>
        public Task<KeyPair> MnemonicDeriveSignKeys(ParamsOfMnemonicDeriveSignKeys @params);

        /// <summary>
        /// Generates an extended master private key that will be the root for all the derived keys.
        /// </summary>
        public Task<ResultOfHDKeyXPrvFromMnemonic> HDKeyXPrvFromMnemonic(ParamsOfHDKeyXPrvFromMnemonic @params);

        /// <summary>
        /// Returns extended private key derived from the specified extended private key and child index.
        /// </summary>
        public Task<ResultOfHDKeyDeriveFromXPrv> HDKeyDeriveFromXPrv(ParamsOfHDKeyDeriveFromXPrv @params);

        /// <summary>
        /// Derives the exented private key from the specified key and path.
        /// </summary>
        public Task<ResultOfHDKeyDeriveFromXPrvPath> HDKeyDeriveFromXPrvPath(ParamsOfHDKeyDeriveFromXPrvPath @params);

        /// <summary>
        /// Extracts the private key from the serialized extended private key.
        /// </summary>
        public Task<ResultOfHDKeySecretFromXPrv> HDKeySecretFromXPrv(ParamsOfHDKeySecretFromXPrv @params);

        /// <summary>
        /// Extracts the public Task<key> from the serialized extended private key.
        /// </summary>
        public Task<ResultOfHDKeyPublicFromXPrv> HDKeyPublicFromXPrv(ParamsOfHDKeyPublicFromXPrv @params);
    }
}
