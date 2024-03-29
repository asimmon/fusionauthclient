// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class LoginConfiguration : IParsable {
        /// <summary>The allowTokenRefresh property</summary>
        public bool? AllowTokenRefresh { get; set; }
        /// <summary>The generateRefreshTokens property</summary>
        public bool? GenerateRefreshTokens { get; set; }
        /// <summary>The requireAuthentication property</summary>
        public bool? RequireAuthentication { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static LoginConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LoginConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowTokenRefresh", n => { AllowTokenRefresh = n.GetBoolValue(); } },
                {"generateRefreshTokens", n => { GenerateRefreshTokens = n.GetBoolValue(); } },
                {"requireAuthentication", n => { RequireAuthentication = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowTokenRefresh", AllowTokenRefresh);
            writer.WriteBoolValue("generateRefreshTokens", GenerateRefreshTokens);
            writer.WriteBoolValue("requireAuthentication", RequireAuthentication);
        }
    }
}
