#nullable enable

namespace LeonardoNS.Client.JsonConverters
{
    /// <inheritdoc />
    public sealed class LcmGenerationStyleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LeonardoNS.Client.LcmGenerationStyle?>
    {
        /// <inheritdoc />
        public override global::LeonardoNS.Client.LcmGenerationStyle? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::LeonardoNS.Client.LcmGenerationStyleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LeonardoNS.Client.LcmGenerationStyle)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LeonardoNS.Client.LcmGenerationStyle? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LeonardoNS.Client.LcmGenerationStyleExtensions.ToValueString(value.Value));
            }
        }
    }
}
