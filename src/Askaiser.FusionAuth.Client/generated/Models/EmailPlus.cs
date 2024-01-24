// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class EmailPlus : IParsable {
        /// <summary>The emailTemplateId property</summary>
        public Guid? EmailTemplateId { get; set; }
        /// <summary>The enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>The maximumTimeToSendEmailInHours property</summary>
        public int? MaximumTimeToSendEmailInHours { get; set; }
        /// <summary>The minimumTimeToSendEmailInHours property</summary>
        public int? MinimumTimeToSendEmailInHours { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EmailPlus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EmailPlus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"emailTemplateId", n => { EmailTemplateId = n.GetGuidValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"maximumTimeToSendEmailInHours", n => { MaximumTimeToSendEmailInHours = n.GetIntValue(); } },
                {"minimumTimeToSendEmailInHours", n => { MinimumTimeToSendEmailInHours = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("emailTemplateId", EmailTemplateId);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteIntValue("maximumTimeToSendEmailInHours", MaximumTimeToSendEmailInHours);
            writer.WriteIntValue("minimumTimeToSendEmailInHours", MinimumTimeToSendEmailInHours);
        }
    }
}
