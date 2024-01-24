// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// A log for an action that was taken on a User.
    /// </summary>
    public class UserActionLog : IParsable {
        /// <summary>The actioneeUserId property</summary>
        public Guid? ActioneeUserId { get; set; }
        /// <summary>The actionerUserId property</summary>
        public Guid? ActionerUserId { get; set; }
        /// <summary>The applicationIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? ApplicationIds { get; set; }
#nullable restore
#else
        public List<Guid?> ApplicationIds { get; set; }
#endif
        /// <summary>The comment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>The emailUserOnEnd property</summary>
        public bool? EmailUserOnEnd { get; set; }
        /// <summary>The endEventSent property</summary>
        public bool? EndEventSent { get; set; }
        /// <summary>The number of milliseconds since the unix epoch: January 1, 1970 00:00:00 UTC. This value is always in UTC.</summary>
        public long? Expiry { get; set; }
        /// <summary>A historical state of a user log event. Since events can be modified, this stores the historical state.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LogHistory? History { get; set; }
#nullable restore
#else
        public LogHistory History { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The number of milliseconds since the unix epoch: January 1, 1970 00:00:00 UTC. This value is always in UTC.</summary>
        public long? InsertInstant { get; set; }
        /// <summary>The localizedName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalizedName { get; set; }
#nullable restore
#else
        public string LocalizedName { get; set; }
#endif
        /// <summary>The localizedOption property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalizedOption { get; set; }
#nullable restore
#else
        public string LocalizedOption { get; set; }
#endif
        /// <summary>The localizedReason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalizedReason { get; set; }
#nullable restore
#else
        public string LocalizedReason { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The notifyUserOnEnd property</summary>
        public bool? NotifyUserOnEnd { get; set; }
        /// <summary>The option property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Option { get; set; }
#nullable restore
#else
        public string Option { get; set; }
#endif
        /// <summary>The reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason { get; set; }
#nullable restore
#else
        public string Reason { get; set; }
#endif
        /// <summary>The reasonCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReasonCode { get; set; }
#nullable restore
#else
        public string ReasonCode { get; set; }
#endif
        /// <summary>The userActionId property</summary>
        public Guid? UserActionId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserActionLog CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserActionLog();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actioneeUserId", n => { ActioneeUserId = n.GetGuidValue(); } },
                {"actionerUserId", n => { ActionerUserId = n.GetGuidValue(); } },
                {"applicationIds", n => { ApplicationIds = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"emailUserOnEnd", n => { EmailUserOnEnd = n.GetBoolValue(); } },
                {"endEventSent", n => { EndEventSent = n.GetBoolValue(); } },
                {"expiry", n => { Expiry = n.GetLongValue(); } },
                {"history", n => { History = n.GetObjectValue<LogHistory>(LogHistory.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"insertInstant", n => { InsertInstant = n.GetLongValue(); } },
                {"localizedName", n => { LocalizedName = n.GetStringValue(); } },
                {"localizedOption", n => { LocalizedOption = n.GetStringValue(); } },
                {"localizedReason", n => { LocalizedReason = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"notifyUserOnEnd", n => { NotifyUserOnEnd = n.GetBoolValue(); } },
                {"option", n => { Option = n.GetStringValue(); } },
                {"reason", n => { Reason = n.GetStringValue(); } },
                {"reasonCode", n => { ReasonCode = n.GetStringValue(); } },
                {"userActionId", n => { UserActionId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("actioneeUserId", ActioneeUserId);
            writer.WriteGuidValue("actionerUserId", ActionerUserId);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("applicationIds", ApplicationIds);
            writer.WriteStringValue("comment", Comment);
            writer.WriteBoolValue("emailUserOnEnd", EmailUserOnEnd);
            writer.WriteBoolValue("endEventSent", EndEventSent);
            writer.WriteLongValue("expiry", Expiry);
            writer.WriteObjectValue<LogHistory>("history", History);
            writer.WriteGuidValue("id", Id);
            writer.WriteLongValue("insertInstant", InsertInstant);
            writer.WriteStringValue("localizedName", LocalizedName);
            writer.WriteStringValue("localizedOption", LocalizedOption);
            writer.WriteStringValue("localizedReason", LocalizedReason);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("notifyUserOnEnd", NotifyUserOnEnd);
            writer.WriteStringValue("option", Option);
            writer.WriteStringValue("reason", Reason);
            writer.WriteStringValue("reasonCode", ReasonCode);
            writer.WriteGuidValue("userActionId", UserActionId);
        }
    }
}