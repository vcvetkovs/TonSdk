using System.Text.Json.Serialization;
using TonSdk.Common.Converters;

namespace TonSdk.Modules.Crypto.Models
{
    public abstract class ResultOfAppPasswordProvider
    {
        [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
        public class GetPassword : ResultOfAppPasswordProvider
        {
            public string EncryptedPassword { get; set; }

            public string AppEncryptionPubkey { get; set; }
        }
    }
}

