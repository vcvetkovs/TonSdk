using System.Text.Json.Serialization;
using EverscaleSdk.Common.Converters;

namespace EverscaleSdk.Modules.Crypto.Models
{
    /// <summary>
    ///     Crypto Box Secret.
    /// </summary>
    public abstract class CryptoBoxSecret
    {
        /// <summary>
        ///     Creates Crypto Box from a random seed phrase.
        ///     This option can be used if a developer doesn't want the seed
        ///     phrase to leave the core library's memory, where it is stored
        ///     encrypted. <para/>
        ///     
        ///     This type should be used upon the first wallet initialization,
        ///     all further initializations should use
        ///     <see cref="CryptoBoxSecret.EncryptedSecret"/> type instead. <para/>
        ///     
        ///     Get <see cref="CryptoBoxSecret.EncryptedSecret"/> with
        ///     <see cref="ICryptoModule.GetCryptoBoxInfo(RegisteredCryptoBox)"/>
        ///     function and store it on your side.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public class RandomSeedPhrase : CryptoBoxSecret
        {
            public byte Dictionary { get; set; }

            public byte Wordcount { get; set; }
        }

        /// <summary>
        ///     Restores crypto box instance from an existing seed phrase.
        ///     This type should be used when Crypto Box is initialized from
        ///     a seed phrase, entered by a user. <para/>
        ///     
        ///     This type should be used upon the first wallet initialization,
        ///     all further initializations should use
        ///     <see cref="CryptoBoxSecret.EncryptedSecret"/> type instead. <para/>
        ///     
        ///     Get <see cref="CryptoBoxSecret.EncryptedSecret"/> with
        ///     <see cref="ICryptoModule.GetCryptoBoxInfo(RegisteredCryptoBox)"/>
        ///     function and store it on your side.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public class PredefinedSeedPhrase : CryptoBoxSecret
        {
            public string Phrase { get; set; }

            public byte Dictionary { get; set; }

            public byte Wordcount { get; set; }
        }

        /// <summary>
        ///     Use this type for wallet reinitializations, when you already
        ///     have <see cref="ResultOfGetCryptoBoxInfo.EncryptedSecret"/> on
        ///     hands.
        ///     To get <see cref="ResultOfGetCryptoBoxInfo.EncryptedSecret"/>,
        ///     use
        ///     <see cref="ICryptoModule.GetCryptoBoxInfo(RegisteredCryptoBox)"/>
        ///     function after you initialized your crypto box for the first time. <para/>
        ///     
        ///     It is an object, containing seed phrase or private key,
        ///     encrypted with
        ///     <see cref="ParamsOfCreateCryptoBox.SecretEncryptionSalt"/> and
        ///     password from <c>password_provider</c>. <para/>
        ///     
        ///     Note that if you want to change salt or password provider, then
        ///     you need to reinitialize the wallet with
        ///     <see cref="PredefinedSeedPhrase"/>, then get
        ///     <see cref="ResultOfGetCryptoBoxInfo.EncryptedSecret"/> via
        ///     <see cref="ICryptoModule.GetCryptoBoxInfo(RegisteredCryptoBox)"/>,
        ///     store it somewhere, and only after that initialize the wallet
        ///     with <see cref="EncryptedSecret"/> type.
        /// </summary>
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public class EncryptedSecret : CryptoBoxSecret
        {
            /// <summary>
            ///     It is an object, containing encrypted seed phrase or private
            ///     key (now we support only seed phrase).
            /// </summary>
            public string EncryptedSecretAccessor { get; set; }
        }
    }
}

