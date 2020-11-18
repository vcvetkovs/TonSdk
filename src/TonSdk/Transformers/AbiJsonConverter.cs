using System;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using TonSdk.Modules.Abi.Enums;
using TonSdk.Modules.Abi.Models;

namespace TonSdk.Transformers
{
    public class AbiJsonConverter : JsonConverter<Abi>
    {
        public override bool CanConvert(Type typeToConvert) =>
            typeof(Abi).IsAssignableFrom(typeToConvert);

        public override Abi Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            reader.Read();
            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            string propertyName = reader.GetString();
            if (propertyName != "TypeDiscriminator")
            {
                throw new JsonException();
            }

            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException();
            }

            AbiType typeDiscriminator = (AbiType)reader.GetInt32();
            Abi value = typeDiscriminator switch
            {
                AbiType.Contract => new Abi.Contract(),
                AbiType.Handle => new Abi.Handle(),
                AbiType.Json => new Abi.Json(),
                AbiType.Serialized => new Abi.Serialized(),
                _ => throw new JsonException()
            };

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return value;
                }

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    propertyName = reader.GetString();
                    reader.Read();
                    switch (propertyName)
                    {
                        case "Value":
                            break;
                    }
                }
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, Abi value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("value");

            switch (value)
            {
                case Abi.Contract contract:
                    JsonSerializer.Serialize(writer, contract.Value, options);
                    break;
                case Abi.Json contract:
                    JsonSerializer.Serialize(writer, contract.Value, options);
                    break;
                case Abi.Handle contract:
                    JsonSerializer.Serialize(writer, contract.Value, options);
                    writer.WriteString("type", value.GetType().Name);
                    break;
                case Abi.Serialized contract:
                    JsonSerializer.Serialize(writer, contract.Value, options);
                    writer.WriteString("type", value.GetType().Name);
                    break;
                default:
                    throw new SerializationException();
            }

            writer.WriteEndObject();
        }
    }
}
