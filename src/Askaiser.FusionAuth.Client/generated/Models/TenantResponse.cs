// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class TenantResponse : IParsable {
        /// <summary>The tenant property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Askaiser.FusionAuth.Client.Models.Tenant? Tenant { get; set; }
#nullable restore
#else
        public Askaiser.FusionAuth.Client.Models.Tenant Tenant { get; set; }
#endif
        /// <summary>The tenants property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Askaiser.FusionAuth.Client.Models.Tenant>? Tenants { get; set; }
#nullable restore
#else
        public List<Askaiser.FusionAuth.Client.Models.Tenant> Tenants { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TenantResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"tenant", n => { Tenant = n.GetObjectValue<Askaiser.FusionAuth.Client.Models.Tenant>(Askaiser.FusionAuth.Client.Models.Tenant.CreateFromDiscriminatorValue); } },
                {"tenants", n => { Tenants = n.GetCollectionOfObjectValues<Askaiser.FusionAuth.Client.Models.Tenant>(Askaiser.FusionAuth.Client.Models.Tenant.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Askaiser.FusionAuth.Client.Models.Tenant>("tenant", Tenant);
            writer.WriteCollectionOfObjectValues<Askaiser.FusionAuth.Client.Models.Tenant>("tenants", Tenants);
        }
    }
}