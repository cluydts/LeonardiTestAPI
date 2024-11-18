#nullable enable

namespace LeonardoNS.Client.JsonConverters
{
    /// <inheritdoc />
    public sealed class UniversalUpscalerUltraStyleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LeonardoNS.Client.UniversalUpscalerUltraStyle>
    {
        /// <inheritdoc />
        public override global::LeonardoNS.Client.UniversalUpscalerUltraStyle Read(
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
                        return global::LeonardoNS.Client.UniversalUpscalerUltraStyleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LeonardoNS.Client.UniversalUpscalerUltraStyle)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LeonardoNS.Client.UniversalUpscalerUltraStyle value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LeonardoNS.Client.UniversalUpscalerUltraStyleExtensions.ToValueString(value));
        }
    }
}
