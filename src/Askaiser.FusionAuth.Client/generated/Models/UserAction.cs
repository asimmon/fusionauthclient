// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// An action that can be executed on a user (discipline or reward potentially).
    /// </summary>
    public class UserAction : IParsable {
        /// <summary>The active property</summary>
        public bool? Active { get; set; }
        /// <summary>The cancelEmailTemplateId property</summary>
        public Guid? CancelEmailTemplateId { get; set; }
        /// <summary>The endEmailTemplateId property</summary>
        public Guid? EndEmailTemplateId { get; set; }
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The includeEmailInEventJSON property</summary>
        public bool? IncludeEmailInEventJSON { get; set; }
        /// <summary>The number of milliseconds since the unix epoch: January 1, 1970 00:00:00 UTC. This value is always in UTC.</summary>
        public long? InsertInstant { get; set; }
        /// <summary>The number of milliseconds since the unix epoch: January 1, 1970 00:00:00 UTC. This value is always in UTC.</summary>
        public long? LastUpdateInstant { get; set; }
        /// <summary>Models a set of localized Strings that can be stored as JSON.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LocalizedStrings? LocalizedNames { get; set; }
#nullable restore
#else
        public LocalizedStrings LocalizedNames { get; set; }
#endif
        /// <summary>The modifyEmailTemplateId property</summary>
        public Guid? ModifyEmailTemplateId { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The options property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserActionOption>? Options { get; set; }
#nullable restore
#else
        public List<UserActionOption> Options { get; set; }
#endif
        /// <summary>The preventLogin property</summary>
        public bool? PreventLogin { get; set; }
        /// <summary>The sendEndEvent property</summary>
        public bool? SendEndEvent { get; set; }
        /// <summary>The startEmailTemplateId property</summary>
        public Guid? StartEmailTemplateId { get; set; }
        /// <summary>The temporal property</summary>
        public bool? Temporal { get; set; }
        /// <summary>The transaction types for Webhooks and other event systems within FusionAuth.</summary>
        public Askaiser.FusionAuth.Client.Models.TransactionType? TransactionType { get; set; }
        /// <summary>The userEmailingEnabled property</summary>
        public bool? UserEmailingEnabled { get; set; }
        /// <summary>The userNotificationsEnabled property</summary>
        public bool? UserNotificationsEnabled { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"active", n => { Active = n.GetBoolValue(); } },
                {"cancelEmailTemplateId", n => { CancelEmailTemplateId = n.GetGuidValue(); } },
                {"endEmailTemplateId", n => { EndEmailTemplateId = n.GetGuidValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"includeEmailInEventJSON", n => { IncludeEmailInEventJSON = n.GetBoolValue(); } },
                {"insertInstant", n => { InsertInstant = n.GetLongValue(); } },
                {"lastUpdateInstant", n => { LastUpdateInstant = n.GetLongValue(); } },
                {"localizedNames", n => { LocalizedNames = n.GetObjectValue<LocalizedStrings>(LocalizedStrings.CreateFromDiscriminatorValue); } },
                {"modifyEmailTemplateId", n => { ModifyEmailTemplateId = n.GetGuidValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"options", n => { Options = n.GetCollectionOfObjectValues<UserActionOption>(UserActionOption.CreateFromDiscriminatorValue)?.ToList(); } },
                {"preventLogin", n => { PreventLogin = n.GetBoolValue(); } },
                {"sendEndEvent", n => { SendEndEvent = n.GetBoolValue(); } },
                {"startEmailTemplateId", n => { StartEmailTemplateId = n.GetGuidValue(); } },
                {"temporal", n => { Temporal = n.GetBoolValue(); } },
                {"transactionType", n => { TransactionType = n.GetEnumValue<TransactionType>(); } },
                {"userEmailingEnabled", n => { UserEmailingEnabled = n.GetBoolValue(); } },
                {"userNotificationsEnabled", n => { UserNotificationsEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("active", Active);
            writer.WriteGuidValue("cancelEmailTemplateId", CancelEmailTemplateId);
            writer.WriteGuidValue("endEmailTemplateId", EndEmailTemplateId);
            writer.WriteGuidValue("id", Id);
            writer.WriteBoolValue("includeEmailInEventJSON", IncludeEmailInEventJSON);
            writer.WriteLongValue("insertInstant", InsertInstant);
            writer.WriteLongValue("lastUpdateInstant", LastUpdateInstant);
            writer.WriteObjectValue<LocalizedStrings>("localizedNames", LocalizedNames);
            writer.WriteGuidValue("modifyEmailTemplateId", ModifyEmailTemplateId);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<UserActionOption>("options", Options);
            writer.WriteBoolValue("preventLogin", PreventLogin);
            writer.WriteBoolValue("sendEndEvent", SendEndEvent);
            writer.WriteGuidValue("startEmailTemplateId", StartEmailTemplateId);
            writer.WriteBoolValue("temporal", Temporal);
            writer.WriteEnumValue<TransactionType>("transactionType", TransactionType);
            writer.WriteBoolValue("userEmailingEnabled", UserEmailingEnabled);
            writer.WriteBoolValue("userNotificationsEnabled", UserNotificationsEnabled);
        }
    }
}