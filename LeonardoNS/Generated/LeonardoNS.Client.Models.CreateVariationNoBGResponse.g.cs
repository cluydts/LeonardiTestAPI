
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVariationNoBGResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdNobgJob")]
        public global::LeonardoNS.Client.CreateVariationNoBGResponseSdNobgJob? SdNobgJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationNoBGResponse" /> class.
        /// </summary>
        /// <param name="sdNobgJob"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateVariationNoBGResponse(
            global::LeonardoNS.Client.CreateVariationNoBGResponseSdNobgJob? sdNobgJob)
        {
            this.SdNobgJob = sdNobgJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationNoBGResponse" /> class.
        /// </summary>
        public CreateVariationNoBGResponse()
        {
        }
    }
}