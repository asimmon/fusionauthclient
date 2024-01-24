// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Entity grant API response object.
    /// </summary>
    public class EntityGrantResponse : IParsable {
        /// <summary>A grant for an entity to a user or another entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EntityGrant? Grant { get; set; }
#nullable restore
#else
        public EntityGrant Grant { get; set; }
#endif
        /// <summary>The grants property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EntityGrant>? Grants { get; set; }
#nullable restore
#else
        public List<EntityGrant> Grants { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EntityGrantResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EntityGrantResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"grant", n => { Grant = n.GetObjectValue<EntityGrant>(EntityGrant.CreateFromDiscriminatorValue); } },
                {"grants", n => { Grants = n.GetCollectionOfObjectValues<EntityGrant>(EntityGrant.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<EntityGrant>("grant", Grant);
            writer.WriteCollectionOfObjectValues<EntityGrant>("grants", Grants);
        }
    }
}
