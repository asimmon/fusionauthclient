// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Audit log response.
    /// </summary>
    public class AuditLogSearchResponse : IParsable {
        /// <summary>The auditLogs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuditLog>? AuditLogs { get; set; }
#nullable restore
#else
        public List<AuditLog> AuditLogs { get; set; }
#endif
        /// <summary>The total property</summary>
        public long? Total { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AuditLogSearchResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditLogSearchResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"auditLogs", n => { AuditLogs = n.GetCollectionOfObjectValues<AuditLog>(AuditLog.CreateFromDiscriminatorValue)?.ToList(); } },
                {"total", n => { Total = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AuditLog>("auditLogs", AuditLogs);
            writer.WriteLongValue("total", Total);
        }
    }
}