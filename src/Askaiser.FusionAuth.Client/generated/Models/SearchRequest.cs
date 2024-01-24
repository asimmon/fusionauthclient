// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Search API request.
    /// </summary>
    public class SearchRequest : IParsable {
        /// <summary>The expand property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Expand { get; set; }
#nullable restore
#else
        public List<string> Expand { get; set; }
#endif
        /// <summary>This class is the user query. It provides a build pattern as well as public fields for use on forms and in actions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserSearchCriteria? Search { get; set; }
#nullable restore
#else
        public UserSearchCriteria Search { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SearchRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expand", n => { Expand = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"search", n => { Search = n.GetObjectValue<UserSearchCriteria>(UserSearchCriteria.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("expand", Expand);
            writer.WriteObjectValue<UserSearchCriteria>("search", Search);
        }
    }
}