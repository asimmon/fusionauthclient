// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// JWT Configuration for entities.
    /// </summary>
    public class EntityJWTConfiguration : IParsable {
        /// <summary>The accessTokenKeyId property</summary>
        public Guid? AccessTokenKeyId { get; set; }
        /// <summary>The enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>The timeToLiveInSeconds property</summary>
        public int? TimeToLiveInSeconds { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EntityJWTConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EntityJWTConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accessTokenKeyId", n => { AccessTokenKeyId = n.GetGuidValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"timeToLiveInSeconds", n => { TimeToLiveInSeconds = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("accessTokenKeyId", AccessTokenKeyId);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteIntValue("timeToLiveInSeconds", TimeToLiveInSeconds);
        }
    }
}