
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateUniversalUpscalerJobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("universalUpscaler")]
        public global::LeonardoNS.Client.CreateUniversalUpscalerJobResponseUniversalUpscaler? UniversalUpscaler { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUniversalUpscalerJobResponse" /> class.
        /// </summary>
        /// <param name="universalUpscaler"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateUniversalUpscalerJobResponse(
            global::LeonardoNS.Client.CreateUniversalUpscalerJobResponseUniversalUpscaler? universalUpscaler)
        {
            this.UniversalUpscaler = universalUpscaler;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUniversalUpscalerJobResponse" /> class.
        /// </summary>
        public CreateUniversalUpscalerJobResponse()
        {
        }
    }
}