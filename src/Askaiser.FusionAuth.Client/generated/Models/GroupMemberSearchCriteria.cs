// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Search criteria for Group Members
    /// </summary>
    public class GroupMemberSearchCriteria : IParsable {
        /// <summary>The groupId property</summary>
        public Guid? GroupId { get; set; }
        /// <summary>The numberOfResults property</summary>
        public int? NumberOfResults { get; set; }
        /// <summary>The orderBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderBy { get; set; }
#nullable restore
#else
        public string OrderBy { get; set; }
#endif
        /// <summary>The startRow property</summary>
        public int? StartRow { get; set; }
        /// <summary>The tenantId property</summary>
        public Guid? TenantId { get; set; }
        /// <summary>The userId property</summary>
        public Guid? UserId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GroupMemberSearchCriteria CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupMemberSearchCriteria();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"groupId", n => { GroupId = n.GetGuidValue(); } },
                {"numberOfResults", n => { NumberOfResults = n.GetIntValue(); } },
                {"orderBy", n => { OrderBy = n.GetStringValue(); } },
                {"startRow", n => { StartRow = n.GetIntValue(); } },
                {"tenantId", n => { TenantId = n.GetGuidValue(); } },
                {"userId", n => { UserId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("groupId", GroupId);
            writer.WriteIntValue("numberOfResults", NumberOfResults);
            writer.WriteStringValue("orderBy", OrderBy);
            writer.WriteIntValue("startRow", StartRow);
            writer.WriteGuidValue("tenantId", TenantId);
            writer.WriteGuidValue("userId", UserId);
        }
    }
}
