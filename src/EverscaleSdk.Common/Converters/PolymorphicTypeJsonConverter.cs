using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using EverscaleSdk.Common.Extensions;
using EverscaleSdk.Common.Helpers;

namespace EverscaleSdk.Common.Converters
{
    public class PolymorphicTypeJsonConverter : PolymorphicTypeJsonConverter<object> { }

    public class PolymorphicTypeJsonConverter<T> : JsonConverter<T>
    {
        public override bool CanConvert(Type typeToConvert) =>
            typeToConvert.BaseType?.GetNestedTypes().Contains(typeToConvert) == true
			|| (typeToConvert.IsAbstract && typeToConvert.GetNestedTypes().All(t => t.BaseType == typeToConvert));

		public override T Read(
			ref Utf8JsonReader reader,
			Type typeToConvert,
			JsonSerializerOptions options)
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

			var typeDiscriminator = reader.GetInt32();

			throw new JsonException();
		}

		public override void Write(
            Utf8JsonWriter writer,
            T value,
            JsonSerializerOptions options) => MapTypeAndAllValues(writer, value, options);

        private void MapTypeAndAllValues<TValue>(
            Utf8JsonWriter writer,
            TValue value,
            JsonSerializerOptions options)
		{
			var type = value.GetType();
			writer.WriteStartObject();
			writer.WriteString("type", type.Name);

			var props = type.GetProperties();
			foreach (var prop in props)
			{
				var propName = prop.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name
					?? prop.Name.ToSnakeCase();
				var propValue = prop.GetValue(value);

				switch (propValue)
				{
					case string convertedValue:
						writer.WriteString(propName, convertedValue.ToSnakeCase());
						break;
					case bool convertedValue:
						writer.WriteBoolean(propName, convertedValue);
						break;
					case int convertedValue:
						writer.WriteNumber(propName, convertedValue);
						break;
					default:
						writer.WritePropertyName(propName);
						JsonSerializer.Serialize(writer, propValue, options);
						break;
				}
			}

			writer.WriteEndObject();
		}
    }
}
