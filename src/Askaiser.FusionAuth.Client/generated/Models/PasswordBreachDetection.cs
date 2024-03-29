// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class PasswordBreachDetection : IParsable {
        /// <summary>The enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>The matchMode property</summary>
        public BreachMatchMode? MatchMode { get; set; }
        /// <summary>The notifyUserEmailTemplateId property</summary>
        public Guid? NotifyUserEmailTemplateId { get; set; }
        /// <summary>The onLogin property</summary>
        public BreachAction? OnLogin { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PasswordBreachDetection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PasswordBreachDetection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"matchMode", n => { MatchMode = n.GetEnumValue<BreachMatchMode>(); } },
                {"notifyUserEmailTemplateId", n => { NotifyUserEmailTemplateId = n.GetGuidValue(); } },
                {"onLogin", n => { OnLogin = n.GetEnumValue<BreachAction>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteEnumValue<BreachMatchMode>("matchMode", MatchMode);
            writer.WriteGuidValue("notifyUserEmailTemplateId", NotifyUserEmailTemplateId);
            writer.WriteEnumValue<BreachAction>("onLogin", OnLogin);
        }
    }
}
