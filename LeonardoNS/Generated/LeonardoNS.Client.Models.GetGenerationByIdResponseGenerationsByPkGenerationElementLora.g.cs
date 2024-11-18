
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// Element used for the generation.
    /// </summary>
    public sealed partial class GetGenerationByIdResponseGenerationsByPkGenerationElementLora
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("akUUID")]
        public global::LeonardoNS.Client.Lora? AkUUID { get; set; }

        /// <summary>
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseModel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LeonardoNS.Client.JsonConverters.SdVersionsJsonConverter))]
        public global::LeonardoNS.Client.SdVersions? BaseModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::LeonardoNS.Client.Lora? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public global::LeonardoNS.Client.Lora? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urlImage")]
        public global::LeonardoNS.Client.Lora? UrlImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightDefault")]
        public global::LeonardoNS.Client.Lora? WeightDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightMax")]
        public global::LeonardoNS.Client.Lora? WeightMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightMin")]
        public global::LeonardoNS.Client.Lora? WeightMin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationByIdResponseGenerationsByPkGenerationElementLora" /> class.
        /// </summary>
        /// <param name="akUUID"></param>
        /// <param name="baseModel">
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="urlImage"></param>
        /// <param name="weightDefault"></param>
        /// <param name="weightMax"></param>
        /// <param name="weightMin"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetGenerationByIdResponseGenerationsByPkGenerationElementLora(
            global::LeonardoNS.Client.Lora? akUUID,
            global::LeonardoNS.Client.SdVersions? baseModel,
            global::LeonardoNS.Client.Lora? description,
            global::LeonardoNS.Client.Lora? name,
            global::LeonardoNS.Client.Lora? urlImage,
            global::LeonardoNS.Client.Lora? weightDefault,
            global::LeonardoNS.Client.Lora? weightMax,
            global::LeonardoNS.Client.Lora? weightMin)
        {
            this.AkUUID = akUUID;
            this.BaseModel = baseModel;
            this.Description = description;
            this.Name = name;
            this.UrlImage = urlImage;
            this.WeightDefault = weightDefault;
            this.WeightMax = weightMax;
            this.WeightMin = weightMin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationByIdResponseGenerationsByPkGenerationElementLora" /> class.
        /// </summary>
        public GetGenerationByIdResponseGenerationsByPkGenerationElementLora()
        {
        }
    }
}