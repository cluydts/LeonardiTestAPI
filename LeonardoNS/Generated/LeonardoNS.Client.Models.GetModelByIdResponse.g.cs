
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetModelByIdResponse
    {
        /// <summary>
        /// columns and relationships of "custom_models"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_models_by_pk")]
        public global::LeonardoNS.Client.GetModelByIdResponseCustomModelsByPk? CustomModelsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelByIdResponse" /> class.
        /// </summary>
        /// <param name="customModelsByPk">
        /// columns and relationships of "custom_models"
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetModelByIdResponse(
            global::LeonardoNS.Client.GetModelByIdResponseCustomModelsByPk? customModelsByPk)
        {
            this.CustomModelsByPk = customModelsByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelByIdResponse" /> class.
        /// </summary>
        public GetModelByIdResponse()
        {
        }
    }
}