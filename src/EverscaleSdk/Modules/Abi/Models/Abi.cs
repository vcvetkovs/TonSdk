using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using EverscaleSdk.Common.Converters;

namespace EverscaleSdk.Modules.Abi.Models
{
    public abstract class Abi
    {
        public class Contract : Abi
        {
            [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
            public AbiContract Value { get; set; }
        }

        public class Json : Abi
        {
            public string Value { get; set; }
        }

        public class Handle : Abi
        {
            public uint Value { get; set; }
        }

        public class Serialized : Abi
        {
            public Serialized() { }
            public Serialized(byte[] abi)
            {
                SetProperties(Encoding.UTF8.GetString(abi));
            }
            public Serialized(string abi)
            {
                SetProperties(abi);
            }

            private void SetProperties(string abi)
            {
                Value = JsonSerializer.Deserialize<AbiContract>(
                    abi,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                        PropertyNamingPolicy = new SnakeCaseNamingPolicy(),
                        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                    }
                ) ?? throw new ArgumentException($"Could not initialize contract -> {abi}");
            }

            [JsonConverter(typeof(PolymorphicTypeJsonConverter))]
            public AbiContract Value { get; set; }
        }
    }
}
