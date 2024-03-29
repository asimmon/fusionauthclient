// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class IPAccessControlEntry : IParsable {
        /// <summary>The action property</summary>
        public IPAccessControlEntryAction? Action { get; set; }
        /// <summary>The endIPAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EndIPAddress { get; set; }
#nullable restore
#else
        public string EndIPAddress { get; set; }
#endif
        /// <summary>The startIPAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartIPAddress { get; set; }
#nullable restore
#else
        public string StartIPAddress { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IPAccessControlEntry CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IPAccessControlEntry();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"action", n => { Action = n.GetEnumValue<IPAccessControlEntryAction>(); } },
                {"endIPAddress", n => { EndIPAddress = n.GetStringValue(); } },
                {"startIPAddress", n => { StartIPAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<IPAccessControlEntryAction>("action", Action);
            writer.WriteStringValue("endIPAddress", EndIPAddress);
            writer.WriteStringValue("startIPAddress", StartIPAddress);
        }
    }
}
