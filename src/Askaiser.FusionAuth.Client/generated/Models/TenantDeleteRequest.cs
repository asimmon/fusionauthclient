// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Request for the Tenant API to delete a tenant rather than using the URL parameters.
    /// </summary>
    public class TenantDeleteRequest : IParsable {
        /// <summary>The async property</summary>
        public bool? Async { get; set; }
        /// <summary>Information about a user event (login, register, etc) that helps identify the source of the event (location, device type, OS, etc).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Askaiser.FusionAuth.Client.Models.EventInfo? EventInfo { get; set; }
#nullable restore
#else
        public Askaiser.FusionAuth.Client.Models.EventInfo EventInfo { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TenantDeleteRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantDeleteRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"async", n => { Async = n.GetBoolValue(); } },
                {"eventInfo", n => { EventInfo = n.GetObjectValue<Askaiser.FusionAuth.Client.Models.EventInfo>(Askaiser.FusionAuth.Client.Models.EventInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("async", Async);
            writer.WriteObjectValue<Askaiser.FusionAuth.Client.Models.EventInfo>("eventInfo", EventInfo);
        }
    }
}
