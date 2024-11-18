
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// columns and relationships of "datasets"
    /// </summary>
    public sealed partial class CreateDatasetResponseInsertDatasetsOne
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetResponseInsertDatasetsOne" /> class.
        /// </summary>
        /// <param name="id"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateDatasetResponseInsertDatasetsOne(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetResponseInsertDatasetsOne" /> class.
        /// </summary>
        public CreateDatasetResponseInsertDatasetsOne()
        {
        }
    }
}