// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class TwoFactorSendRequest : IParsable {
        /// <summary>The applicationId property</summary>
        public Guid? ApplicationId { get; set; }
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The method property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Method { get; set; }
#nullable restore
#else
        public string Method { get; set; }
#endif
        /// <summary>The methodId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MethodId { get; set; }
#nullable restore
#else
        public string MethodId { get; set; }
#endif
        /// <summary>The mobilePhone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MobilePhone { get; set; }
#nullable restore
#else
        public string MobilePhone { get; set; }
#endif
        /// <summary>The userId property</summary>
        public Guid? UserId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TwoFactorSendRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TwoFactorSendRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applicationId", n => { ApplicationId = n.GetGuidValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"method", n => { Method = n.GetStringValue(); } },
                {"methodId", n => { MethodId = n.GetStringValue(); } },
                {"mobilePhone", n => { MobilePhone = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("applicationId", ApplicationId);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("method", Method);
            writer.WriteStringValue("methodId", MethodId);
            writer.WriteStringValue("mobilePhone", MobilePhone);
            writer.WriteGuidValue("userId", UserId);
        }
    }
}