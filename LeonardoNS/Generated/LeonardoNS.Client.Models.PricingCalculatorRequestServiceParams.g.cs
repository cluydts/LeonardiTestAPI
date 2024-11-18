
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// Parameters for the service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParams
    {
        /// <summary>
        /// Parameters for IMAGE_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("IMAGE_GENERATION")]
        public global::LeonardoNS.Client.PricingCalculatorRequestServiceParamsIMAGEGENERATION? IMAGEGENERATION { get; set; }

        /// <summary>
        /// Parameters for FANTASY_AVATAR_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("FANTASY_AVATAR_GENERATION")]
        public global::LeonardoNS.Client.PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION? FANTASYAVATARGENERATION { get; set; }

        /// <summary>
        /// Parameters for MOTION_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MOTION_GENERATION")]
        public global::LeonardoNS.Client.PricingCalculatorRequestServiceParamsMOTIONGENERATION? MOTIONGENERATION { get; set; }

        /// <summary>
        /// Parameters for LCM_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LCM_GENERATION")]
        public global::LeonardoNS.Client.PricingCalculatorRequestServiceParamsLCMGENERATION? LCMGENERATION { get; set; }

        /// <summary>
        /// Parameters for MODEL_TRAINING service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MODEL_TRAINING")]
        public global::LeonardoNS.Client.PricingCalculatorRequestServiceParamsMODELTRAINING? MODELTRAINING { get; set; }

        /// <summary>
        /// Parameters for TEXTURE_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TEXTURE_GENERATION")]
        public global::LeonardoNS.Client.PricingCalculatorRequestServiceParamsTEXTUREGENERATION? TEXTUREGENERATION { get; set; }

        /// <summary>
        /// Parameters for UNIVERSAL_UPSCALER service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("UNIVERSAL_UPSCALER")]
        public global::LeonardoNS.Client.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER? UNIVERSALUPSCALER { get; set; }

        /// <summary>
        /// Parameters for UNIVERSAL_UPSCALER_ULTRA service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("UNIVERSAL_UPSCALER_ULTRA")]
        public global::LeonardoNS.Client.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALERULTRA? UNIVERSALUPSCALERULTRA { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParams" /> class.
        /// </summary>
        /// <param name="iMAGEGENERATION">
        /// Parameters for IMAGE_GENERATION service
        /// </param>
        /// <param name="fANTASYAVATARGENERATION">
        /// Parameters for FANTASY_AVATAR_GENERATION service
        /// </param>
        /// <param name="mOTIONGENERATION">
        /// Parameters for MOTION_GENERATION service
        /// </param>
        /// <param name="lCMGENERATION">
        /// Parameters for LCM_GENERATION service
        /// </param>
        /// <param name="mODELTRAINING">
        /// Parameters for MODEL_TRAINING service
        /// </param>
        /// <param name="tEXTUREGENERATION">
        /// Parameters for TEXTURE_GENERATION service
        /// </param>
        /// <param name="uNIVERSALUPSCALER">
        /// Parameters for UNIVERSAL_UPSCALER service
        /// </param>
        /// <param name="uNIVERSALUPSCALERULTRA">
        /// Parameters for UNIVERSAL_UPSCALER_ULTRA service
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PricingCalculatorRequestServiceParams(
            global::LeonardoNS.Client.PricingCalculatorRequestServiceParamsIMAGEGENERATION? iMAGEGENERATION,
            global::LeonardoNS.Client.PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION? fANTASYAVATARGENERATION,
            global::LeonardoNS.Client.PricingCalculatorRequestServiceParamsMOTIONGENERATION? mOTIONGENERATION,
            global::LeonardoNS.Client.PricingCalculatorRequestServiceParamsLCMGENERATION? lCMGENERATION,
            global::LeonardoNS.Client.PricingCalculatorRequestServiceParamsMODELTRAINING? mODELTRAINING,
            global::LeonardoNS.Client.PricingCalculatorRequestServiceParamsTEXTUREGENERATION? tEXTUREGENERATION,
            global::LeonardoNS.Client.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER? uNIVERSALUPSCALER,
            global::LeonardoNS.Client.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALERULTRA? uNIVERSALUPSCALERULTRA)
        {
            this.IMAGEGENERATION = iMAGEGENERATION;
            this.FANTASYAVATARGENERATION = fANTASYAVATARGENERATION;
            this.MOTIONGENERATION = mOTIONGENERATION;
            this.LCMGENERATION = lCMGENERATION;
            this.MODELTRAINING = mODELTRAINING;
            this.TEXTUREGENERATION = tEXTUREGENERATION;
            this.UNIVERSALUPSCALER = uNIVERSALUPSCALER;
            this.UNIVERSALUPSCALERULTRA = uNIVERSALUPSCALERULTRA;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParams" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParams()
        {
        }
    }
}