
#nullable enable

namespace LeonardoNS.Client
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserSelfResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_details")]
        public global::System.Collections.Generic.IList<global::LeonardoNS.Client.GetUserSelfResponseUserDetail>? UserDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserSelfResponse" /> class.
        /// </summary>
        /// <param name="userDetails"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetUserSelfResponse(
            global::System.Collections.Generic.IList<global::LeonardoNS.Client.GetUserSelfResponseUserDetail>? userDetails)
        {
            this.UserDetails = userDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserSelfResponse" /> class.
        /// </summary>
        public GetUserSelfResponse()
        {
        }
    }
}