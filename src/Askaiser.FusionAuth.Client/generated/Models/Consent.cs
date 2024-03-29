// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Models a consent.
    /// </summary>
    public class Consent : IParsable {
        /// <summary>The consentEmailTemplateId property</summary>
        public Guid? ConsentEmailTemplateId { get; set; }
        /// <summary>Models a set of localized Integers that can be stored as JSON.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LocalizedIntegers? CountryMinimumAgeForSelfConsent { get; set; }
#nullable restore
#else
        public LocalizedIntegers CountryMinimumAgeForSelfConsent { get; set; }
#endif
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Consent_data? Data { get; set; }
#nullable restore
#else
        public Consent_data Data { get; set; }
#endif
        /// <summary>The defaultMinimumAgeForSelfConsent property</summary>
        public int? DefaultMinimumAgeForSelfConsent { get; set; }
        /// <summary>The emailPlus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Askaiser.FusionAuth.Client.Models.EmailPlus? EmailPlus { get; set; }
#nullable restore
#else
        public Askaiser.FusionAuth.Client.Models.EmailPlus EmailPlus { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The number of milliseconds since the unix epoch: January 1, 1970 00:00:00 UTC. This value is always in UTC.</summary>
        public long? InsertInstant { get; set; }
        /// <summary>The number of milliseconds since the unix epoch: January 1, 1970 00:00:00 UTC. This value is always in UTC.</summary>
        public long? LastUpdateInstant { get; set; }
        /// <summary>The multipleValuesAllowed property</summary>
        public bool? MultipleValuesAllowed { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The values property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Values { get; set; }
#nullable restore
#else
        public List<string> Values { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Consent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Consent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"consentEmailTemplateId", n => { ConsentEmailTemplateId = n.GetGuidValue(); } },
                {"countryMinimumAgeForSelfConsent", n => { CountryMinimumAgeForSelfConsent = n.GetObjectValue<LocalizedIntegers>(LocalizedIntegers.CreateFromDiscriminatorValue); } },
                {"data", n => { Data = n.GetObjectValue<Consent_data>(Consent_data.CreateFromDiscriminatorValue); } },
                {"defaultMinimumAgeForSelfConsent", n => { DefaultMinimumAgeForSelfConsent = n.GetIntValue(); } },
                {"emailPlus", n => { EmailPlus = n.GetObjectValue<Askaiser.FusionAuth.Client.Models.EmailPlus>(Askaiser.FusionAuth.Client.Models.EmailPlus.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"insertInstant", n => { InsertInstant = n.GetLongValue(); } },
                {"lastUpdateInstant", n => { LastUpdateInstant = n.GetLongValue(); } },
                {"multipleValuesAllowed", n => { MultipleValuesAllowed = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"values", n => { Values = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("consentEmailTemplateId", ConsentEmailTemplateId);
            writer.WriteObjectValue<LocalizedIntegers>("countryMinimumAgeForSelfConsent", CountryMinimumAgeForSelfConsent);
            writer.WriteObjectValue<Consent_data>("data", Data);
            writer.WriteIntValue("defaultMinimumAgeForSelfConsent", DefaultMinimumAgeForSelfConsent);
            writer.WriteObjectValue<Askaiser.FusionAuth.Client.Models.EmailPlus>("emailPlus", EmailPlus);
            writer.WriteGuidValue("id", Id);
            writer.WriteLongValue("insertInstant", InsertInstant);
            writer.WriteLongValue("lastUpdateInstant", LastUpdateInstant);
            writer.WriteBoolValue("multipleValuesAllowed", MultipleValuesAllowed);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfPrimitiveValues<string>("values", Values);
        }
    }
}
