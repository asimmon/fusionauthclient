// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class IdentityProviderOauth2Configuration : IParsable {
        /// <summary>The authorization_endpoint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthorizationEndpoint { get; set; }
#nullable restore
#else
        public string AuthorizationEndpoint { get; set; }
#endif
        /// <summary>The clientAuthenticationMethod property</summary>
        public Askaiser.FusionAuth.Client.Models.ClientAuthenticationMethod? ClientAuthenticationMethod { get; set; }
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
        /// <summary>The emailClaim property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailClaim { get; set; }
#nullable restore
#else
        public string EmailClaim { get; set; }
#endif
        /// <summary>The emailVerifiedClaim property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailVerifiedClaim { get; set; }
#nullable restore
#else
        public string EmailVerifiedClaim { get; set; }
#endif
        /// <summary>The issuer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Issuer { get; set; }
#nullable restore
#else
        public string Issuer { get; set; }
#endif
        /// <summary>The scope property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Scope { get; set; }
#nullable restore
#else
        public string Scope { get; set; }
#endif
        /// <summary>The token_endpoint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenEndpoint { get; set; }
#nullable restore
#else
        public string TokenEndpoint { get; set; }
#endif
        /// <summary>The uniqueIdClaim property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UniqueIdClaim { get; set; }
#nullable restore
#else
        public string UniqueIdClaim { get; set; }
#endif
        /// <summary>The userinfo_endpoint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserinfoEndpoint { get; set; }
#nullable restore
#else
        public string UserinfoEndpoint { get; set; }
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
        public static IdentityProviderOauth2Configuration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IdentityProviderOauth2Configuration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"authorization_endpoint", n => { AuthorizationEndpoint = n.GetStringValue(); } },
                {"clientAuthenticationMethod", n => { ClientAuthenticationMethod = n.GetEnumValue<ClientAuthenticationMethod>(); } },
                {"client_id", n => { ClientId = n.GetStringValue(); } },
                {"client_secret", n => { ClientSecret = n.GetStringValue(); } },
                {"emailClaim", n => { EmailClaim = n.GetStringValue(); } },
                {"emailVerifiedClaim", n => { EmailVerifiedClaim = n.GetStringValue(); } },
                {"issuer", n => { Issuer = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetStringValue(); } },
                {"token_endpoint", n => { TokenEndpoint = n.GetStringValue(); } },
                {"uniqueIdClaim", n => { UniqueIdClaim = n.GetStringValue(); } },
                {"userinfo_endpoint", n => { UserinfoEndpoint = n.GetStringValue(); } },
                {"usernameClaim", n => { UsernameClaim = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("authorization_endpoint", AuthorizationEndpoint);
            writer.WriteEnumValue<ClientAuthenticationMethod>("clientAuthenticationMethod", ClientAuthenticationMethod);
            writer.WriteStringValue("client_id", ClientId);
            writer.WriteStringValue("client_secret", ClientSecret);
            writer.WriteStringValue("emailClaim", EmailClaim);
            writer.WriteStringValue("emailVerifiedClaim", EmailVerifiedClaim);
            writer.WriteStringValue("issuer", Issuer);
            writer.WriteStringValue("scope", Scope);
            writer.WriteStringValue("token_endpoint", TokenEndpoint);
            writer.WriteStringValue("uniqueIdClaim", UniqueIdClaim);
            writer.WriteStringValue("userinfo_endpoint", UserinfoEndpoint);
            writer.WriteStringValue("usernameClaim", UsernameClaim);
        }
    }
}
