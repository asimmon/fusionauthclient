// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    /// <summary>
    /// Registration API request object.
    /// </summary>
    public class RegistrationRequest : IParsable {
        /// <summary>The disableDomainBlock property</summary>
        public bool? DisableDomainBlock { get; set; }
        /// <summary>Information about a user event (login, register, etc) that helps identify the source of the event (location, device type, OS, etc).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Askaiser.FusionAuth.Client.Models.EventInfo? EventInfo { get; set; }
#nullable restore
#else
        public Askaiser.FusionAuth.Client.Models.EventInfo EventInfo { get; set; }
#endif
        /// <summary>The generateAuthenticationToken property</summary>
        public bool? GenerateAuthenticationToken { get; set; }
        /// <summary>User registration information for a single application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserRegistration? Registration { get; set; }
#nullable restore
#else
        public UserRegistration Registration { get; set; }
#endif
        /// <summary>The sendSetPasswordEmail property</summary>
        public bool? SendSetPasswordEmail { get; set; }
        /// <summary>The skipRegistrationVerification property</summary>
        public bool? SkipRegistrationVerification { get; set; }
        /// <summary>The skipVerification property</summary>
        public bool? SkipVerification { get; set; }
        /// <summary>The global view of a User. This object contains all global information about the user including birth date, registration information  preferred languages, global attributes, etc.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Askaiser.FusionAuth.Client.Models.User? User { get; set; }
#nullable restore
#else
        public Askaiser.FusionAuth.Client.Models.User User { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RegistrationRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RegistrationRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"disableDomainBlock", n => { DisableDomainBlock = n.GetBoolValue(); } },
                {"eventInfo", n => { EventInfo = n.GetObjectValue<Askaiser.FusionAuth.Client.Models.EventInfo>(Askaiser.FusionAuth.Client.Models.EventInfo.CreateFromDiscriminatorValue); } },
                {"generateAuthenticationToken", n => { GenerateAuthenticationToken = n.GetBoolValue(); } },
                {"registration", n => { Registration = n.GetObjectValue<UserRegistration>(UserRegistration.CreateFromDiscriminatorValue); } },
                {"sendSetPasswordEmail", n => { SendSetPasswordEmail = n.GetBoolValue(); } },
                {"skipRegistrationVerification", n => { SkipRegistrationVerification = n.GetBoolValue(); } },
                {"skipVerification", n => { SkipVerification = n.GetBoolValue(); } },
                {"user", n => { User = n.GetObjectValue<Askaiser.FusionAuth.Client.Models.User>(Askaiser.FusionAuth.Client.Models.User.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("disableDomainBlock", DisableDomainBlock);
            writer.WriteObjectValue<Askaiser.FusionAuth.Client.Models.EventInfo>("eventInfo", EventInfo);
            writer.WriteBoolValue("generateAuthenticationToken", GenerateAuthenticationToken);
            writer.WriteObjectValue<UserRegistration>("registration", Registration);
            writer.WriteBoolValue("sendSetPasswordEmail", SendSetPasswordEmail);
            writer.WriteBoolValue("skipRegistrationVerification", SkipRegistrationVerification);
            writer.WriteBoolValue("skipVerification", SkipVerification);
            writer.WriteObjectValue<Askaiser.FusionAuth.Client.Models.User>("user", User);
        }
    }
}