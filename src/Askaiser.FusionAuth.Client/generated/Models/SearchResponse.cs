// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Search API response.
    /// </summary>
    public class SearchResponse : IParsable {
        /// <summary>The expandable property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Expandable { get; set; }
#nullable restore
#else
        public List<string> Expandable { get; set; }
#endif
        /// <summary>The nextResults property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NextResults { get; set; }
#nullable restore
#else
        public string NextResults { get; set; }
#endif
        /// <summary>The total property</summary>
        public long? Total { get; set; }
        /// <summary>The users property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<User>? Users { get; set; }
#nullable restore
#else
        public List<User> Users { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SearchResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expandable", n => { Expandable = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"nextResults", n => { NextResults = n.GetStringValue(); } },
                {"total", n => { Total = n.GetLongValue(); } },
                {"users", n => { Users = n.GetCollectionOfObjectValues<User>(User.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("expandable", Expandable);
            writer.WriteStringValue("nextResults", NextResults);
            writer.WriteLongValue("total", Total);
            writer.WriteCollectionOfObjectValues<User>("users", Users);
        }
    }
}