// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Tenant-level configuration for WebAuthn
    /// </summary>
    public class TenantWebAuthnConfiguration : IParsable {
        /// <summary>The bootstrapWorkflow property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TenantWebAuthnWorkflowConfiguration? BootstrapWorkflow { get; set; }
#nullable restore
#else
        public TenantWebAuthnWorkflowConfiguration BootstrapWorkflow { get; set; }
#endif
        /// <summary>The debug property</summary>
        public bool? Debug { get; set; }
        /// <summary>The enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>The reauthenticationWorkflow property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TenantWebAuthnWorkflowConfiguration? ReauthenticationWorkflow { get; set; }
#nullable restore
#else
        public TenantWebAuthnWorkflowConfiguration ReauthenticationWorkflow { get; set; }
#endif
        /// <summary>The relyingPartyId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RelyingPartyId { get; set; }
#nullable restore
#else
        public string RelyingPartyId { get; set; }
#endif
        /// <summary>The relyingPartyName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RelyingPartyName { get; set; }
#nullable restore
#else
        public string RelyingPartyName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TenantWebAuthnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantWebAuthnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bootstrapWorkflow", n => { BootstrapWorkflow = n.GetObjectValue<TenantWebAuthnWorkflowConfiguration>(TenantWebAuthnWorkflowConfiguration.CreateFromDiscriminatorValue); } },
                {"debug", n => { Debug = n.GetBoolValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"reauthenticationWorkflow", n => { ReauthenticationWorkflow = n.GetObjectValue<TenantWebAuthnWorkflowConfiguration>(TenantWebAuthnWorkflowConfiguration.CreateFromDiscriminatorValue); } },
                {"relyingPartyId", n => { RelyingPartyId = n.GetStringValue(); } },
                {"relyingPartyName", n => { RelyingPartyName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TenantWebAuthnWorkflowConfiguration>("bootstrapWorkflow", BootstrapWorkflow);
            writer.WriteBoolValue("debug", Debug);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteObjectValue<TenantWebAuthnWorkflowConfiguration>("reauthenticationWorkflow", ReauthenticationWorkflow);
            writer.WriteStringValue("relyingPartyId", RelyingPartyId);
            writer.WriteStringValue("relyingPartyName", RelyingPartyName);
        }
    }
}
