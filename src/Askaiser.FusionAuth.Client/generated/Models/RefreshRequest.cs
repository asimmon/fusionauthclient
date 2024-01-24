// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class RefreshRequest : IParsable {
        /// <summary>Information about a user event (login, register, etc) that helps identify the source of the event (location, device type, OS, etc).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Askaiser.FusionAuth.Client.Models.EventInfo? EventInfo { get; set; }
#nullable restore
#else
        public Askaiser.FusionAuth.Client.Models.EventInfo EventInfo { get; set; }
#endif
        /// <summary>The refreshToken property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RefreshToken { get; set; }
#nullable restore
#else
        public string RefreshToken { get; set; }
#endif
        /// <summary>The token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RefreshRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RefreshRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"eventInfo", n => { EventInfo = n.GetObjectValue<Askaiser.FusionAuth.Client.Models.EventInfo>(Askaiser.FusionAuth.Client.Models.EventInfo.CreateFromDiscriminatorValue); } },
                {"refreshToken", n => { RefreshToken = n.GetStringValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Askaiser.FusionAuth.Client.Models.EventInfo>("eventInfo", EventInfo);
            writer.WriteStringValue("refreshToken", RefreshToken);
            writer.WriteStringValue("token", Token);
        }
    }
}