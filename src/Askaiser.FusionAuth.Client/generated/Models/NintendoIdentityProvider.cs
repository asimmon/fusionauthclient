// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Nintendo gaming login provider.
    /// </summary>
    public class NintendoIdentityProvider : IParsable {
        /// <summary>The applicationConfiguration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NintendoIdentityProvider_applicationConfiguration? ApplicationConfiguration { get; set; }
#nullable restore
#else
        public NintendoIdentityProvider_applicationConfiguration ApplicationConfiguration { get; set; }
#endif
        /// <summary>The buttonText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ButtonText { get; set; }
#nullable restore
#else
        public string ButtonText { get; set; }
#endif
        /// <summary>The client_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientId { get; set; }
#nullable restore
#else
        public string ClientId { get; set; }
#endif
        /// <summary>The client_secret property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientSecret { get; set; }
#nullable restore
#else
        public string ClientSecret { get; set; }
#endif
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NintendoIdentityProvider_data? Data { get; set; }
#nullable restore
#else
        public NintendoIdentityProvider_data Data { get; set; }
#endif
        /// <summary>The debug property</summary>
        public bool? Debug { get; set; }
        /// <summary>The emailClaim property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailClaim { get; set; }
#nullable restore
#else
        public string EmailClaim { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The number of milliseconds since the unix epoch: January 1, 1970 00:00:00 UTC. This value is always in UTC.</summary>
        public long? InsertInstant { get; set; }
        /// <summary>The lambdaConfiguration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProviderLambdaConfiguration? LambdaConfiguration { get; set; }
#nullable restore
#else
        public ProviderLambdaConfiguration LambdaConfiguration { get; set; }
#endif
        /// <summary>The number of milliseconds since the unix epoch: January 1, 1970 00:00:00 UTC. This value is always in UTC.</summary>
        public long? LastUpdateInstant { get; set; }
        /// <summary>The IdP behavior when no user link has been made yet.</summary>
        public IdentityProviderLinkingStrategy? LinkingStrategy { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The scope property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Scope { get; set; }
#nullable restore
#else
        public string Scope { get; set; }
#endif
        /// <summary>The tenantConfiguration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NintendoIdentityProvider_tenantConfiguration? TenantConfiguration { get; set; }
#nullable restore
#else
        public NintendoIdentityProvider_tenantConfiguration TenantConfiguration { get; set; }
#endif
        /// <summary>The type property</summary>
        public IdentityProviderType? Type { get; set; }
        /// <summary>The uniqueIdClaim property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UniqueIdClaim { get; set; }
#nullable restore
#else
        public string UniqueIdClaim { get; set; }
#endif
        /// <summary>The usernameClaim property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UsernameClaim { get; set; }
#nullable restore
#else
        public string UsernameClaim { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static NintendoIdentityProvider CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NintendoIdentityProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applicationConfiguration", n => { ApplicationConfiguration = n.GetObjectValue<NintendoIdentityProvider_applicationConfiguration>(NintendoIdentityProvider_applicationConfiguration.CreateFromDiscriminatorValue); } },
                {"buttonText", n => { ButtonText = n.GetStringValue(); } },
                {"client_id", n => { ClientId = n.GetStringValue(); } },
                {"client_secret", n => { ClientSecret = n.GetStringValue(); } },
                {"data", n => { Data = n.GetObjectValue<NintendoIdentityProvider_data>(NintendoIdentityProvider_data.CreateFromDiscriminatorValue); } },
                {"debug", n => { Debug = n.GetBoolValue(); } },
                {"emailClaim", n => { EmailClaim = n.GetStringValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"insertInstant", n => { InsertInstant = n.GetLongValue(); } },
                {"lambdaConfiguration", n => { LambdaConfiguration = n.GetObjectValue<ProviderLambdaConfiguration>(ProviderLambdaConfiguration.CreateFromDiscriminatorValue); } },
                {"lastUpdateInstant", n => { LastUpdateInstant = n.GetLongValue(); } },
                {"linkingStrategy", n => { LinkingStrategy = n.GetEnumValue<IdentityProviderLinkingStrategy>(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetStringValue(); } },
                {"tenantConfiguration", n => { TenantConfiguration = n.GetObjectValue<NintendoIdentityProvider_tenantConfiguration>(NintendoIdentityProvider_tenantConfiguration.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetEnumValue<IdentityProviderType>(); } },
                {"uniqueIdClaim", n => { UniqueIdClaim = n.GetStringValue(); } },
                {"usernameClaim", n => { UsernameClaim = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<NintendoIdentityProvider_applicationConfiguration>("applicationConfiguration", ApplicationConfiguration);
            writer.WriteStringValue("buttonText", ButtonText);
            writer.WriteStringValue("client_id", ClientId);
            writer.WriteStringValue("client_secret", ClientSecret);
            writer.WriteObjectValue<NintendoIdentityProvider_data>("data", Data);
            writer.WriteBoolValue("debug", Debug);
            writer.WriteStringValue("emailClaim", EmailClaim);
            writer.WriteGuidValue("id", Id);
            writer.WriteLongValue("insertInstant", InsertInstant);
            writer.WriteObjectValue<ProviderLambdaConfiguration>("lambdaConfiguration", LambdaConfiguration);
            writer.WriteLongValue("lastUpdateInstant", LastUpdateInstant);
            writer.WriteEnumValue<IdentityProviderLinkingStrategy>("linkingStrategy", LinkingStrategy);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("scope", Scope);
            writer.WriteObjectValue<NintendoIdentityProvider_tenantConfiguration>("tenantConfiguration", TenantConfiguration);
            writer.WriteEnumValue<IdentityProviderType>("type", Type);
            writer.WriteStringValue("uniqueIdClaim", UniqueIdClaim);
            writer.WriteStringValue("usernameClaim", UsernameClaim);
        }
    }
}
