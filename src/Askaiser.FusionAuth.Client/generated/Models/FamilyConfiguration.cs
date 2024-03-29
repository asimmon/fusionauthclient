// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class FamilyConfiguration : IParsable {
        /// <summary>The allowChildRegistrations property</summary>
        public bool? AllowChildRegistrations { get; set; }
        /// <summary>The confirmChildEmailTemplateId property</summary>
        public Guid? ConfirmChildEmailTemplateId { get; set; }
        /// <summary>The deleteOrphanedAccounts property</summary>
        public bool? DeleteOrphanedAccounts { get; set; }
        /// <summary>The deleteOrphanedAccountsDays property</summary>
        public int? DeleteOrphanedAccountsDays { get; set; }
        /// <summary>The enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>The familyRequestEmailTemplateId property</summary>
        public Guid? FamilyRequestEmailTemplateId { get; set; }
        /// <summary>The maximumChildAge property</summary>
        public int? MaximumChildAge { get; set; }
        /// <summary>The minimumOwnerAge property</summary>
        public int? MinimumOwnerAge { get; set; }
        /// <summary>The parentEmailRequired property</summary>
        public bool? ParentEmailRequired { get; set; }
        /// <summary>The parentRegistrationEmailTemplateId property</summary>
        public Guid? ParentRegistrationEmailTemplateId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FamilyConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FamilyConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowChildRegistrations", n => { AllowChildRegistrations = n.GetBoolValue(); } },
                {"confirmChildEmailTemplateId", n => { ConfirmChildEmailTemplateId = n.GetGuidValue(); } },
                {"deleteOrphanedAccounts", n => { DeleteOrphanedAccounts = n.GetBoolValue(); } },
                {"deleteOrphanedAccountsDays", n => { DeleteOrphanedAccountsDays = n.GetIntValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"familyRequestEmailTemplateId", n => { FamilyRequestEmailTemplateId = n.GetGuidValue(); } },
                {"maximumChildAge", n => { MaximumChildAge = n.GetIntValue(); } },
                {"minimumOwnerAge", n => { MinimumOwnerAge = n.GetIntValue(); } },
                {"parentEmailRequired", n => { ParentEmailRequired = n.GetBoolValue(); } },
                {"parentRegistrationEmailTemplateId", n => { ParentRegistrationEmailTemplateId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowChildRegistrations", AllowChildRegistrations);
            writer.WriteGuidValue("confirmChildEmailTemplateId", ConfirmChildEmailTemplateId);
            writer.WriteBoolValue("deleteOrphanedAccounts", DeleteOrphanedAccounts);
            writer.WriteIntValue("deleteOrphanedAccountsDays", DeleteOrphanedAccountsDays);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteGuidValue("familyRequestEmailTemplateId", FamilyRequestEmailTemplateId);
            writer.WriteIntValue("maximumChildAge", MaximumChildAge);
            writer.WriteIntValue("minimumOwnerAge", MinimumOwnerAge);
            writer.WriteBoolValue("parentEmailRequired", ParentEmailRequired);
            writer.WriteGuidValue("parentRegistrationEmailTemplateId", ParentRegistrationEmailTemplateId);
        }
    }
}
