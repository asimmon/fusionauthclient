// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class LoginRecordSearchRequest : IParsable {
        /// <summary>The retrieveTotal property</summary>
        public bool? RetrieveTotal { get; set; }
        /// <summary>The search property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LoginRecordSearchCriteria? Search { get; set; }
#nullable restore
#else
        public LoginRecordSearchCriteria Search { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static LoginRecordSearchRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LoginRecordSearchRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"retrieveTotal", n => { RetrieveTotal = n.GetBoolValue(); } },
                {"search", n => { Search = n.GetObjectValue<LoginRecordSearchCriteria>(LoginRecordSearchCriteria.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("retrieveTotal", RetrieveTotal);
            writer.WriteObjectValue<LoginRecordSearchCriteria>("search", Search);
        }
    }
}