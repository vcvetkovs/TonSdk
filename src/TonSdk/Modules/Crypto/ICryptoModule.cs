using System;
using System.Text.Json;
using System.Threading.Tasks;
using TonSdk.Modules.Crypto.Models;

namespace TonSdk.Modules.Crypto
{
    /// <summary>
    ///     Crypto functions.
    /// </summary>
    public interface ICryptoModule
    {
        /// <summary>
        ///     Integer factorization.
        /// </summary>
        /// <remarks>
        ///     Performs prime factorization – decomposition of a composite number
        ///     into a product of smaller prime integers (factors).
        ///     See [https://en.wikipedia.org/wiki/Integer_factorization]
        /// </remarks>
        Task<ResultOfFactorize> Factorize(ParamsOfFactorize @params);

        /// <summary>
        ///     Modular exponentiation.
        /// </summary>
        /// <remarks>
        ///     Performs modular exponentiation for big integers (<c>base</c>^<c>exponent</c> mod <c>modulus</c>).
        ///     See [https://en.wikipedia.org/wiki/Modular_exponentiation]
        /// </remarks>
        Task<ResultOfModularPower> ModularPower(ParamsOfModularPower @params);

        /// <summary>
        ///     Calculates CRC16 using TON algorithm.
        /// </summary>
        Task<ResultOfTonCrc16> TonCrc16(ParamsOfTonCrc16 @params);

        /// <summary>
        ///     Generates random byte array of the specified length and returns it in <c>base64</c> format.
        /// </summary>
        Task<ResultOfGenerateRandomBytes> GenerateRandomBytes(ParamsOfGenerateRandomBytes @params);

        /// <summary>
        ///     Converts public key to ton safe_format.
        /// </summary>
        Task<ResultOfConvertPublicKeyToTonSafeFormat> ConvertPublicKeyToTonSafeFormat(
            ParamsOfConvertPublicKeyToTonSafeFormat @params);

        /// <summary>
        ///     Generates random ed25519 key pair.
        /// </summary>
        Task<KeyPair> GenerateRandomSignKeys();

        /// <summary>
        ///     Signs a data using the provided keys.
        /// </summary>
        Task<ResultOfSign> Sign(ParamsOfSign @params);

        /// <summary>
        ///     Verifies signed data using the provided public key.
        ///     Raises error if verification is failed.
        /// </summary>
        Task<ResultOfVerifySignature> VerifySignature(ParamsOfVerifySignature @params);

        /// <summary>
        ///     Calculates SHA256 hash of the specified data.
        /// </summary>
        Task<ResultOfHash> Sha256(ParamsOfHash @params);

        /// <summary>
        ///     Calculates SHA512 hash of the specified data.
        /// </summary>
        Task<ResultOfHash> Sha512(ParamsOfHash @params);

        /// <summary>
        ///     Perform `scrypt` encryption.
        /// </summary>
        /// <remarks>
        ///     Derives key from `password` and `key` using `scrypt` algorithm.
        ///     See [https://en.wikipedia.org/wiki/Scrypt].
        ///  
        ///     # Arguments
        ///      <list type="bullet">
        ///       <item>
        ///        <term>log_n</term>
        ///        <description>The log2 of the Scrypt parameter `N`</description>
        ///       </item>
        ///       <item>
        ///        <term>r</term>
        ///        <description>The Scrypt parameter `r`</description>
        ///       </item>
        ///       <item>
        ///        <term>p</term>
        ///        <description>The Scrypt parameter `p`</description>
        ///       </item>
        ///      </list>
        ///     <para/>
        ///      # Conditions
        ///       <list type="bullet">
        ///        <item>
        ///         <term>log_n</term>
        ///         <description>must be less than `64`</description>
        ///        </item>
        ///        <item>
        ///         <term>r</term>
        ///         <description>must be greater than `0` and less than or equal to `4294967295`</description>
        ///        </item>
        ///        <item>
        ///         <term>p</term>
        ///         <description>must be greater than `0` and less than `4294967295`</description>
        ///        </item>
        ///       </list>
        ///     <para/>
        ///      # Recommended values sufficient for most use-cases:
        ///       <list type="bullet">
        ///        <item>
        ///         <term>log_n = 15</term>
        ///         <description>(`n = 32768`)</description>
        ///        </item>
        ///        <item>
        ///         <term>r = 8</term>
        ///        </item>
        ///        <item>
        ///         <term>p = 1</term>
        ///        </item>
        ///       </list>
        ///     <para/>
        /// </remarks>
        Task<ResultOfScrypt> Scrypt(ParamsOfScrypt @params);

        /// <summary>
        ///     Verifies the signature with public key and `unsigned` data.
        /// </summary>
        Task<ResultOfNaclSignDetachedVerify> NaclSignDetachedVerify(ParamsOfNaclSignDetachedVerify @params);

        /// <summary>
        ///     Generates a key pair for signing from the secret key.
        /// </summary>
        /// <remarks>
        ///     **NOTE:** In the result the secret key is actually the concatenation
        ///     of secret and public keys (128 symbols hex string) by design of [NaCL](http://nacl.cr.yp.to/sign.html).
        ///  <para/>
        ///     See also [the stackexchange question](https://crypto.stackexchange.com/questions/54353/).
        ///  <para/>
        /// </remarks>
        Task<KeyPair> NaclSignKeypairFromSecretKey(ParamsOfNaclSignKeyPairFromSecret @params);

        /// <summary>
        ///     Signs data using the signer's secret key.
        /// </summary>
        Task<ResultOfNaclSign> NaclSign(ParamsOfNaclSign @params);

        /// <summary>
        ///     Verifies the signature in `signed` using the signer's public key `public`
        ///     and returns the message `unsigned`.
        ///     
        ///     If the signature fails verification, crypto_sign_open raises an exception.
        /// </summary>
        Task<ResultOfNaclSignOpen> NaclSignOpen(ParamsOfNaclSignOpen @params);

        /// <summary>
        ///     Signs the message `unsigned` using the secret key `secret`
        ///     and returns a signature `signature`.
        /// </summary>
        Task<ResultOfNaclSignDetached> NaclSignDetached(ParamsOfNaclSign @params);

        /// <summary>
        ///     Generates a random NaCl key pair
        /// </summary>
        Task<KeyPair> NaclBoxKeypair();

        /// <summary>
        ///     Generates key pair from a secret key.
        /// </summary>
        Task<KeyPair> NaclBoxKeypairFromSecretKey(ParamsOfNaclBoxKeyPairFromSecret @params);

        /// <summary>
        ///     Public key authenticated encryption.
        /// </summary>
        /// <remarks>
        ///     Encrypt and authenticate a message using the senders secret key, the receivers public
        ///     key, and a nonce. 
        /// </remarks>
        Task<ResultOfNaclBox> NaclBox(ParamsOfNaclBox @params);

        /// <summary>
        ///     Decrypt and verify the cipher text using the receivers secret key, the senders public
        ///     key, and the nonce.
        /// </summary>
        Task<ResultOfNaclBoxOpen> NaclBoxOpen(ParamsOfNaclBoxOpen @params);

        /// <summary>
        ///     Encrypt and authenticate message using nonce and secret key.
        /// </summary>
        Task<ResultOfNaclBox> NaclSecretBox(ParamsOfNaclSecretBox @params);

        /// <summary>
        ///     Decrypts and verifies cipher text using `nonce` and secret `key`.
        /// </summary>
        Task<ResultOfNaclBoxOpen> NaclSecretBoxOpen(ParamsOfNaclSecretBoxOpen @params);

        /// <summary>
        ///     Prints the list of words from the specified dictionary.
        /// </summary>
        Task<ResultOfMnemonicWords> MnemonicWords(ParamsOfMnemonicWords @params);

        /// <summary>
        ///     Generates a random mnemonic from the specified dictionary and word count
        /// </summary>
        Task<ResultOfMnemonicFromRandom> MnemonicFromRandom(ParamsOfMnemonicFromRandom @params);

        /// <summary>
        ///     Generates mnemonic from pre-generated entropy.
        /// </summary>
        Task<ResultOfMnemonicFromEntropy> MnemonicFromEntropy(ParamsOfMnemonicFromEntropy @params);

        /// <summary>
        ///     Validates a mnemonic phrase.
        /// </summary>
        /// <remarks>
        ///     The phrase supplied will be checked for word length and validated according to the checksum
        ///     specified in BIP0039.
        /// </remarks>
        Task<ResultOfMnemonicVerify> MnemonicVerify(ParamsOfMnemonicVerify @params);

        /// <summary>
        ///     Derives a key pair for signing from the seed phrase.
        /// </summary>
        /// <remarks>
        ///     Validates the seed phrase, generates master key and then derives
        ///     the key pair from the master key and the specified path.
        /// </remarks>
        Task<KeyPair> MnemonicDeriveSignKeys(ParamsOfMnemonicDeriveSignKeys @params);

        /// <summary>
        ///     Generates an extended master private key that will be the root for all the derived keys.
        /// </summary>
        Task<ResultOfHDKeyXPrvFromMnemonic> HDKeyXPrvFromMnemonic(ParamsOfHDKeyXPrvFromMnemonic @params);

        /// <summary>
        ///     Returns extended private key derived from the specified extended private key and child index.
        /// </summary>
        Task<ResultOfHDKeyDeriveFromXPrv> HDKeyDeriveFromXPrv(ParamsOfHDKeyDeriveFromXPrv @params);

        /// <summary>
        ///     Derives the extended private key from the specified key and path.
        /// </summary>
        Task<ResultOfHDKeyDeriveFromXPrvPath> HDKeyDeriveFromXPrvPath(ParamsOfHDKeyDeriveFromXPrvPath @params);

        /// <summary>
        ///     Extracts the private key from the serialized extended private key.
        /// </summary>
        Task<ResultOfHDKeySecretFromXPrv> HDKeySecretFromXPrv(ParamsOfHDKeySecretFromXPrv @params);

        /// <summary>
        ///     Extracts the Task<key> from the serialized extended private key.
        /// </summary>
        Task<ResultOfHDKeyPublicFromXPrv> HDKeyPublicFromXPrv(ParamsOfHDKeyPublicFromXPrv @params);

        /// <summary>
        ///     Performs symmetric `chacha20` encryption.
        /// </summary>
        Task<ResultOfHDKeyPublicFromXPrv> Chacha20(ParamsOfHDKeyPublicFromXPrv @params);

        /// <summary>
        ///     Register an application implemented signing box.
        /// </summary>
        Task<RegisteredSigningBox> RegisterSigningBox(Action<JsonElement, uint> callback = null);

        /// <summary>
        ///     Creates a default signing box implementation.
        /// </summary>
        Task<RegisteredSigningBox> GetSigningBox(KeyPair @params);

        /// <summary>
        ///     Returns public key of signing key pair.
        /// </summary>
        Task<ResultOfSigningBoxGetPublicKey> SigningBoxGetPublicKey(RegisteredSigningBox @params);

        /// <summary>
        ///     Returns signed user data.
        /// </summary>
        Task<ResultOfSigningBoxSign> SigningBoxSign(ParamsOfSigningBoxSign @params);

        /// <summary>
        ///     Removes signing box from SDK.
        /// </summary>
        Task RemoveSigningBox(RegisteredSigningBox @params);

        /// <summary>
        ///     Register an application implemented encryption box.
        /// </summary>
        Task<RegisteredEncryptionBox> RegisterEncryptionBox(Func<ParamsOfAppEncryptionBox, Task<ResultOfAppEncryptionBox>> callback);

        /// <summary>
        ///     Removes encryption box from SDK.
        /// </summary>
        Task RemoveEncryptionBox(RegisteredEncryptionBox @params);

        /// <summary>
        ///     Queries info from the given encryption box.
        /// </summary>
        Task<ResultOfEncryptionBoxGetInfo> EncryptionBoxGetInfo(ParamsOfEncryptionBoxGetInfo @params);

        /// <summary>
        ///     Encrypts data using given encryption box.
        /// </summary>
        /// <remarks>
        ///     Block cipher algorithms pad data to cipher block size
        ///     so encrypted data can be longer then original data. <para />
        ///      
        ///     Client should store the original data size after
        ///     encryption and use it after decryption to retrieve
        ///     the original data from decrypted data.
        /// </remarks>
        Task<ResultOfEncryptionBoxEncrypt> EncryptionBoxEncrypt(ParamsOfEncryptionBoxEncrypt @params);

        /// <summary>
        ///     Decrypts data using given encryption box.
        /// </summary>
        /// <remarks>
        ///     Block cipher algorithms pad data to cipher block size
        ///     so encrypted data can be longer then original data. <para />
        ///      
        ///     Client should store the original data size after
        ///     encryption and use it after decryption to retrieve
        ///     the original data from decrypted data.
        /// </remarks>
        Task<ResultOfEncryptionBoxDecrypt> EncryptionBoxDecrypt(ParamsOfEncryptionBoxDecrypt @params);

        /// <summary>
        ///     Creates encryption box with specified algorithm.
        /// </summary>
        public Task<RegisteredEncryptionBox> CreateEncryptionBox(ParamsOfCreateEncryptionBox @params);
    }
}
