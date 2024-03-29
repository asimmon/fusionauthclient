// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Configuration for the behavior of failed login attempts. This helps us protect against brute force password attacks.
    /// </summary>
    public class FailedAuthenticationConfiguration : IParsable {
        /// <summary>A policy to configure if and when the user-action is canceled prior to the expiration of the action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FailedAuthenticationActionCancelPolicy? ActionCancelPolicy { get; set; }
#nullable restore
#else
        public FailedAuthenticationActionCancelPolicy ActionCancelPolicy { get; set; }
#endif
        /// <summary>The actionDuration property</summary>
        public long? ActionDuration { get; set; }
        /// <summary>The actionDurationUnit property</summary>
        public ExpiryUnit? ActionDurationUnit { get; set; }
        /// <summary>The emailUser property</summary>
        public bool? EmailUser { get; set; }
        /// <summary>The resetCountInSeconds property</summary>
        public int? ResetCountInSeconds { get; set; }
        /// <summary>The tooManyAttempts property</summary>
        public int? TooManyAttempts { get; set; }
        /// <summary>The userActionId property</summary>
        public Guid? UserActionId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FailedAuthenticationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FailedAuthenticationConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actionCancelPolicy", n => { ActionCancelPolicy = n.GetObjectValue<FailedAuthenticationActionCancelPolicy>(FailedAuthenticationActionCancelPolicy.CreateFromDiscriminatorValue); } },
                {"actionDuration", n => { ActionDuration = n.GetLongValue(); } },
                {"actionDurationUnit", n => { ActionDurationUnit = n.GetEnumValue<ExpiryUnit>(); } },
                {"emailUser", n => { EmailUser = n.GetBoolValue(); } },
                {"resetCountInSeconds", n => { ResetCountInSeconds = n.GetIntValue(); } },
                {"tooManyAttempts", n => { TooManyAttempts = n.GetIntValue(); } },
                {"userActionId", n => { UserActionId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<FailedAuthenticationActionCancelPolicy>("actionCancelPolicy", ActionCancelPolicy);
            writer.WriteLongValue("actionDuration", ActionDuration);
            writer.WriteEnumValue<ExpiryUnit>("actionDurationUnit", ActionDurationUnit);
            writer.WriteBoolValue("emailUser", EmailUser);
            writer.WriteIntValue("resetCountInSeconds", ResetCountInSeconds);
            writer.WriteIntValue("tooManyAttempts", TooManyAttempts);
            writer.WriteGuidValue("userActionId", UserActionId);
        }
    }
}
