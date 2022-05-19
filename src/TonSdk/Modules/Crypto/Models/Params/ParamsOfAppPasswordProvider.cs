using System.Text.Json.Serialization;
using TonSdk.Common.Converters;

namespace TonSdk.Modules.Crypto.Models
{
    /// <summary>
    ///     Interface that provides a callback that returns an encrypted password,
    ///     used for cryptobox secret encryption. <para />
    ///     
    ///     To secure the password while passing it from application to the library,
    ///     the library generates a temporary key pair, passes the pubkey to the
    ///     passwordProvider, decrypts the received password with private key, and
    ///     deletes the key pair right away. <para />
    ///     
    ///     Application should generate a temporary nacl_box_keypair and encrypt the
    ///     password with naclbox function using nacl_box_keypair.secret and
    ///     encryption_public_key keys + nonce = 24-byte prefix of
    ///     encryption_public_key.
    /// </summary>
    public abstract class ParamsOfAppPasswordProvider
    {
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public class GetPassword : ParamsOfAppPasswordProvider
        {
            public string EncryptionPublicKey { get; set; }
        }
    }
}

