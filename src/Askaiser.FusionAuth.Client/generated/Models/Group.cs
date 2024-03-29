// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class Group : IParsable {
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Group_data? Data { get; set; }
#nullable restore
#else
        public Group_data Data { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The number of milliseconds since the unix epoch: January 1, 1970 00:00:00 UTC. This value is always in UTC.</summary>
        public long? InsertInstant { get; set; }
        /// <summary>The number of milliseconds since the unix epoch: January 1, 1970 00:00:00 UTC. This value is always in UTC.</summary>
        public long? LastUpdateInstant { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The roles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApplicationRole>? Roles { get; set; }
#nullable restore
#else
        public List<ApplicationRole> Roles { get; set; }
#endif
        /// <summary>The tenantId property</summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Group CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Group();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"data", n => { Data = n.GetObjectValue<Group_data>(Group_data.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"insertInstant", n => { InsertInstant = n.GetLongValue(); } },
                {"lastUpdateInstant", n => { LastUpdateInstant = n.GetLongValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"roles", n => { Roles = n.GetCollectionOfObjectValues<ApplicationRole>(ApplicationRole.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantId", n => { TenantId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Group_data>("data", Data);
            writer.WriteGuidValue("id", Id);
            writer.WriteLongValue("insertInstant", InsertInstant);
            writer.WriteLongValue("lastUpdateInstant", LastUpdateInstant);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<ApplicationRole>("roles", Roles);
            writer.WriteGuidValue("tenantId", TenantId);
        }
    }
}
