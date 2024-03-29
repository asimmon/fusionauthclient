// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// The Application API request object.
    /// </summary>
    public class ApplicationRequest : IParsable {
        /// <summary>The application property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Askaiser.FusionAuth.Client.Models.Application? Application { get; set; }
#nullable restore
#else
        public Askaiser.FusionAuth.Client.Models.Application Application { get; set; }
#endif
        /// <summary>Information about a user event (login, register, etc) that helps identify the source of the event (location, device type, OS, etc).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Askaiser.FusionAuth.Client.Models.EventInfo? EventInfo { get; set; }
#nullable restore
#else
        public Askaiser.FusionAuth.Client.Models.EventInfo EventInfo { get; set; }
#endif
        /// <summary>A role given to a user for a specific application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApplicationRole? Role { get; set; }
#nullable restore
#else
        public ApplicationRole Role { get; set; }
#endif
        /// <summary>The sourceApplicationId property</summary>
        public Guid? SourceApplicationId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ApplicationRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplicationRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"application", n => { Application = n.GetObjectValue<Askaiser.FusionAuth.Client.Models.Application>(Askaiser.FusionAuth.Client.Models.Application.CreateFromDiscriminatorValue); } },
                {"eventInfo", n => { EventInfo = n.GetObjectValue<Askaiser.FusionAuth.Client.Models.EventInfo>(Askaiser.FusionAuth.Client.Models.EventInfo.CreateFromDiscriminatorValue); } },
                {"role", n => { Role = n.GetObjectValue<ApplicationRole>(ApplicationRole.CreateFromDiscriminatorValue); } },
                {"sourceApplicationId", n => { SourceApplicationId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Askaiser.FusionAuth.Client.Models.Application>("application", Application);
            writer.WriteObjectValue<Askaiser.FusionAuth.Client.Models.EventInfo>("eventInfo", EventInfo);
            writer.WriteObjectValue<ApplicationRole>("role", Role);
            writer.WriteGuidValue("sourceApplicationId", SourceApplicationId);
        }
    }
}
