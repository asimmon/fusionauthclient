// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class DeviceApprovalResponse : IParsable {
        /// <summary>The deviceGrantStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceGrantStatus { get; set; }
#nullable restore
#else
        public string DeviceGrantStatus { get; set; }
#endif
        /// <summary>The deviceInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Askaiser.FusionAuth.Client.Models.DeviceInfo? DeviceInfo { get; set; }
#nullable restore
#else
        public Askaiser.FusionAuth.Client.Models.DeviceInfo DeviceInfo { get; set; }
#endif
        /// <summary>The identityProviderLink property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Askaiser.FusionAuth.Client.Models.IdentityProviderLink? IdentityProviderLink { get; set; }
#nullable restore
#else
        public Askaiser.FusionAuth.Client.Models.IdentityProviderLink IdentityProviderLink { get; set; }
#endif
        /// <summary>The tenantId property</summary>
        public Guid? TenantId { get; set; }
        /// <summary>The userId property</summary>
        public Guid? UserId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceApprovalResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceApprovalResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceGrantStatus", n => { DeviceGrantStatus = n.GetStringValue(); } },
                {"deviceInfo", n => { DeviceInfo = n.GetObjectValue<Askaiser.FusionAuth.Client.Models.DeviceInfo>(Askaiser.FusionAuth.Client.Models.DeviceInfo.CreateFromDiscriminatorValue); } },
                {"identityProviderLink", n => { IdentityProviderLink = n.GetObjectValue<Askaiser.FusionAuth.Client.Models.IdentityProviderLink>(Askaiser.FusionAuth.Client.Models.IdentityProviderLink.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("deviceGrantStatus", DeviceGrantStatus);
            writer.WriteObjectValue<Askaiser.FusionAuth.Client.Models.DeviceInfo>("deviceInfo", DeviceInfo);
            writer.WriteObjectValue<Askaiser.FusionAuth.Client.Models.IdentityProviderLink>("identityProviderLink", IdentityProviderLink);
            writer.WriteGuidValue("tenantId", TenantId);
            writer.WriteGuidValue("userId", UserId);
        }
    }
}
