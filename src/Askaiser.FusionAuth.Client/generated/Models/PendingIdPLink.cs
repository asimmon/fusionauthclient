// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class PendingIdPLink : IParsable {
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The identityProviderId property</summary>
        public Guid? IdentityProviderId { get; set; }
        /// <summary>The identityProviderLinks property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityProviderLink>? IdentityProviderLinks { get; set; }
#nullable restore
#else
        public List<IdentityProviderLink> IdentityProviderLinks { get; set; }
#endif
        /// <summary>The identityProviderName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityProviderName { get; set; }
#nullable restore
#else
        public string IdentityProviderName { get; set; }
#endif
        /// <summary>The identityProviderTenantConfiguration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Askaiser.FusionAuth.Client.Models.IdentityProviderTenantConfiguration? IdentityProviderTenantConfiguration { get; set; }
#nullable restore
#else
        public Askaiser.FusionAuth.Client.Models.IdentityProviderTenantConfiguration IdentityProviderTenantConfiguration { get; set; }
#endif
        /// <summary>The identityProviderType property</summary>
        public Askaiser.FusionAuth.Client.Models.IdentityProviderType? IdentityProviderType { get; set; }
        /// <summary>The identityProviderUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityProviderUserId { get; set; }
#nullable restore
#else
        public string IdentityProviderUserId { get; set; }
#endif
        /// <summary>The global view of a User. This object contains all global information about the user including birth date, registration information  preferred languages, global attributes, etc.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Askaiser.FusionAuth.Client.Models.User? User { get; set; }
#nullable restore
#else
        public Askaiser.FusionAuth.Client.Models.User User { get; set; }
#endif
        /// <summary>The username property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Username { get; set; }
#nullable restore
#else
        public string Username { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PendingIdPLink CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PendingIdPLink();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"identityProviderId", n => { IdentityProviderId = n.GetGuidValue(); } },
                {"identityProviderLinks", n => { IdentityProviderLinks = n.GetCollectionOfObjectValues<IdentityProviderLink>(IdentityProviderLink.CreateFromDiscriminatorValue)?.ToList(); } },
                {"identityProviderName", n => { IdentityProviderName = n.GetStringValue(); } },
                {"identityProviderTenantConfiguration", n => { IdentityProviderTenantConfiguration = n.GetObjectValue<Askaiser.FusionAuth.Client.Models.IdentityProviderTenantConfiguration>(Askaiser.FusionAuth.Client.Models.IdentityProviderTenantConfiguration.CreateFromDiscriminatorValue); } },
                {"identityProviderType", n => { IdentityProviderType = n.GetEnumValue<IdentityProviderType>(); } },
                {"identityProviderUserId", n => { IdentityProviderUserId = n.GetStringValue(); } },
                {"user", n => { User = n.GetObjectValue<Askaiser.FusionAuth.Client.Models.User>(Askaiser.FusionAuth.Client.Models.User.CreateFromDiscriminatorValue); } },
                {"username", n => { Username = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteGuidValue("identityProviderId", IdentityProviderId);
            writer.WriteCollectionOfObjectValues<IdentityProviderLink>("identityProviderLinks", IdentityProviderLinks);
            writer.WriteStringValue("identityProviderName", IdentityProviderName);
            writer.WriteObjectValue<Askaiser.FusionAuth.Client.Models.IdentityProviderTenantConfiguration>("identityProviderTenantConfiguration", IdentityProviderTenantConfiguration);
            writer.WriteEnumValue<IdentityProviderType>("identityProviderType", IdentityProviderType);
            writer.WriteStringValue("identityProviderUserId", IdentityProviderUserId);
            writer.WriteObjectValue<Askaiser.FusionAuth.Client.Models.User>("user", User);
            writer.WriteStringValue("username", Username);
        }
    }
}