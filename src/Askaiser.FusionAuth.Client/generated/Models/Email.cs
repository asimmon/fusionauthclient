// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// This class is an abstraction of a simple email message.
    /// </summary>
    public class Email : IParsable {
        /// <summary>The attachments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Attachment>? Attachments { get; set; }
#nullable restore
#else
        public List<Attachment> Attachments { get; set; }
#endif
        /// <summary>The bcc property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EmailAddress>? Bcc { get; set; }
#nullable restore
#else
        public List<EmailAddress> Bcc { get; set; }
#endif
        /// <summary>The cc property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EmailAddress>? Cc { get; set; }
#nullable restore
#else
        public List<EmailAddress> Cc { get; set; }
#endif
        /// <summary>An email address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailAddress? From { get; set; }
#nullable restore
#else
        public EmailAddress From { get; set; }
#endif
        /// <summary>The html property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Html { get; set; }
#nullable restore
#else
        public string Html { get; set; }
#endif
        /// <summary>An email address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailAddress? ReplyTo { get; set; }
#nullable restore
#else
        public EmailAddress ReplyTo { get; set; }
#endif
        /// <summary>The subject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>The text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text { get; set; }
#nullable restore
#else
        public string Text { get; set; }
#endif
        /// <summary>The to property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EmailAddress>? To { get; set; }
#nullable restore
#else
        public List<EmailAddress> To { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Email CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Email();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<Attachment>(Attachment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"bcc", n => { Bcc = n.GetCollectionOfObjectValues<EmailAddress>(EmailAddress.CreateFromDiscriminatorValue)?.ToList(); } },
                {"cc", n => { Cc = n.GetCollectionOfObjectValues<EmailAddress>(EmailAddress.CreateFromDiscriminatorValue)?.ToList(); } },
                {"from", n => { From = n.GetObjectValue<EmailAddress>(EmailAddress.CreateFromDiscriminatorValue); } },
                {"html", n => { Html = n.GetStringValue(); } },
                {"replyTo", n => { ReplyTo = n.GetObjectValue<EmailAddress>(EmailAddress.CreateFromDiscriminatorValue); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"text", n => { Text = n.GetStringValue(); } },
                {"to", n => { To = n.GetCollectionOfObjectValues<EmailAddress>(EmailAddress.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Attachment>("attachments", Attachments);
            writer.WriteCollectionOfObjectValues<EmailAddress>("bcc", Bcc);
            writer.WriteCollectionOfObjectValues<EmailAddress>("cc", Cc);
            writer.WriteObjectValue<EmailAddress>("from", From);
            writer.WriteStringValue("html", Html);
            writer.WriteObjectValue<EmailAddress>("replyTo", ReplyTo);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("text", Text);
            writer.WriteCollectionOfObjectValues<EmailAddress>("to", To);
        }
    }
}
