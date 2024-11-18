
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteGenerationByIdResponse
    {
        /// <summary>
        /// columns and relationships of "generations"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_generations_by_pk")]
        public global::LeonardoNS.Client.DeleteGenerationByIdResponseDeleteGenerationsByPk? DeleteGenerationsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGenerationByIdResponse" /> class.
        /// </summary>
        /// <param name="deleteGenerationsByPk">
        /// columns and relationships of "generations"
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeleteGenerationByIdResponse(
            global::LeonardoNS.Client.DeleteGenerationByIdResponseDeleteGenerationsByPk? deleteGenerationsByPk)
        {
            this.DeleteGenerationsByPk = deleteGenerationsByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGenerationByIdResponse" /> class.
        /// </summary>
        public DeleteGenerationByIdResponse()
        {
        }
    }
}