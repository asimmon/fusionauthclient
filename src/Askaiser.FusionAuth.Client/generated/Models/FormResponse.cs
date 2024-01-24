// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Form response.
    /// </summary>
    public class FormResponse : IParsable {
        /// <summary>The form property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Askaiser.FusionAuth.Client.Models.Form? Form { get; set; }
#nullable restore
#else
        public Askaiser.FusionAuth.Client.Models.Form Form { get; set; }
#endif
        /// <summary>The forms property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Askaiser.FusionAuth.Client.Models.Form>? Forms { get; set; }
#nullable restore
#else
        public List<Askaiser.FusionAuth.Client.Models.Form> Forms { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FormResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FormResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"form", n => { Form = n.GetObjectValue<Askaiser.FusionAuth.Client.Models.Form>(Askaiser.FusionAuth.Client.Models.Form.CreateFromDiscriminatorValue); } },
                {"forms", n => { Forms = n.GetCollectionOfObjectValues<Askaiser.FusionAuth.Client.Models.Form>(Askaiser.FusionAuth.Client.Models.Form.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Askaiser.FusionAuth.Client.Models.Form>("form", Form);
            writer.WriteCollectionOfObjectValues<Askaiser.FusionAuth.Client.Models.Form>("forms", Forms);
        }
    }
}
