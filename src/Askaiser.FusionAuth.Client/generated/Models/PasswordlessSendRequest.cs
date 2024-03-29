// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class PasswordlessSendRequest : IParsable {
        /// <summary>The applicationId property</summary>
        public Guid? ApplicationId { get; set; }
        /// <summary>The code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Code { get; set; }
#nullable restore
#else
        public string Code { get; set; }
#endif
        /// <summary>The loginId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LoginId { get; set; }
#nullable restore
#else
        public string LoginId { get; set; }
#endif
        /// <summary>The state property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PasswordlessSendRequest_state? State { get; set; }
#nullable restore
#else
        public PasswordlessSendRequest_state State { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PasswordlessSendRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PasswordlessSendRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applicationId", n => { ApplicationId = n.GetGuidValue(); } },
                {"code", n => { Code = n.GetStringValue(); } },
                {"loginId", n => { LoginId = n.GetStringValue(); } },
                {"state", n => { State = n.GetObjectValue<PasswordlessSendRequest_state>(PasswordlessSendRequest_state.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("applicationId", ApplicationId);
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("loginId", LoginId);
            writer.WriteObjectValue<PasswordlessSendRequest_state>("state", State);
        }
    }
}
