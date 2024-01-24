// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class IPAccessControlListRequest : IParsable {
        /// <summary>The ipAccessControlList property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Askaiser.FusionAuth.Client.Models.IPAccessControlList? IpAccessControlList { get; set; }
#nullable restore
#else
        public Askaiser.FusionAuth.Client.Models.IPAccessControlList IpAccessControlList { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IPAccessControlListRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IPAccessControlListRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ipAccessControlList", n => { IpAccessControlList = n.GetObjectValue<Askaiser.FusionAuth.Client.Models.IPAccessControlList>(Askaiser.FusionAuth.Client.Models.IPAccessControlList.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Askaiser.FusionAuth.Client.Models.IPAccessControlList>("ipAccessControlList", IpAccessControlList);
        }
    }
}
