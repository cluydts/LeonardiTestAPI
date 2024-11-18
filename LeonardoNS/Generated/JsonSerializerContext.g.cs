
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace LeonardoNS.Client
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::LeonardoNS.Client.JsonConverters.SdVersionsJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.SdVersionsNullableJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.StrengthJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.StrengthNullableJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.JobStatusJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.JobStatusNullableJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.MODELASSETTEXTURETYPESJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.MODELASSETTEXTURETYPESNullableJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.CustomModelTypeJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.CustomModelTypeNullableJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.SdGenerationSchedulersJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.SdGenerationSchedulersNullableJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.VARIATIONTYPEJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.VARIATIONTYPENullableJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.ControlnetInputInitImageTypeJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.ControlnetInputInitImageTypeNullableJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.ControlnetInputStrengthTypeJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.ControlnetInputStrengthTypeNullableJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.SdGenerationStyleJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.SdGenerationStyleNullableJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.LcmGenerationStyleJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.LcmGenerationStyleNullableJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.UniversalUpscalerStyleJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.UniversalUpscalerStyleNullableJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.UniversalUpscalerUltraStyleJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.UniversalUpscalerUltraStyleNullableJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.ControlnetTypeJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.ControlnetTypeNullableJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.PricingCalculatorServicesJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.PricingCalculatorServicesNullableJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.CanvasRequestTypeJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.CanvasRequestTypeNullableJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.CreateGenerationRequestTransparencyJsonConverter),
            typeof(global::LeonardoNS.Client.JsonConverters.CreateGenerationRequestTransparencyNullableJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LeonardoNS.Client.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}