// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Askaiser.FusionAuth.Client.Models {
    public class TenantRateLimitConfiguration : IParsable {
        /// <summary>The failedLogin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimitedRequestConfiguration? FailedLogin { get; set; }
#nullable restore
#else
        public RateLimitedRequestConfiguration FailedLogin { get; set; }
#endif
        /// <summary>The forgotPassword property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimitedRequestConfiguration? ForgotPassword { get; set; }
#nullable restore
#else
        public RateLimitedRequestConfiguration ForgotPassword { get; set; }
#endif
        /// <summary>The sendEmailVerification property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimitedRequestConfiguration? SendEmailVerification { get; set; }
#nullable restore
#else
        public RateLimitedRequestConfiguration SendEmailVerification { get; set; }
#endif
        /// <summary>The sendPasswordless property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimitedRequestConfiguration? SendPasswordless { get; set; }
#nullable restore
#else
        public RateLimitedRequestConfiguration SendPasswordless { get; set; }
#endif
        /// <summary>The sendRegistrationVerification property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimitedRequestConfiguration? SendRegistrationVerification { get; set; }
#nullable restore
#else
        public RateLimitedRequestConfiguration SendRegistrationVerification { get; set; }
#endif
        /// <summary>The sendTwoFactor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RateLimitedRequestConfiguration? SendTwoFactor { get; set; }
#nullable restore
#else
        public RateLimitedRequestConfiguration SendTwoFactor { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TenantRateLimitConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantRateLimitConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"failedLogin", n => { FailedLogin = n.GetObjectValue<RateLimitedRequestConfiguration>(RateLimitedRequestConfiguration.CreateFromDiscriminatorValue); } },
                {"forgotPassword", n => { ForgotPassword = n.GetObjectValue<RateLimitedRequestConfiguration>(RateLimitedRequestConfiguration.CreateFromDiscriminatorValue); } },
                {"sendEmailVerification", n => { SendEmailVerification = n.GetObjectValue<RateLimitedRequestConfiguration>(RateLimitedRequestConfiguration.CreateFromDiscriminatorValue); } },
                {"sendPasswordless", n => { SendPasswordless = n.GetObjectValue<RateLimitedRequestConfiguration>(RateLimitedRequestConfiguration.CreateFromDiscriminatorValue); } },
                {"sendRegistrationVerification", n => { SendRegistrationVerification = n.GetObjectValue<RateLimitedRequestConfiguration>(RateLimitedRequestConfiguration.CreateFromDiscriminatorValue); } },
                {"sendTwoFactor", n => { SendTwoFactor = n.GetObjectValue<RateLimitedRequestConfiguration>(RateLimitedRequestConfiguration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<RateLimitedRequestConfiguration>("failedLogin", FailedLogin);
            writer.WriteObjectValue<RateLimitedRequestConfiguration>("forgotPassword", ForgotPassword);
            writer.WriteObjectValue<RateLimitedRequestConfiguration>("sendEmailVerification", SendEmailVerification);
            writer.WriteObjectValue<RateLimitedRequestConfiguration>("sendPasswordless", SendPasswordless);
            writer.WriteObjectValue<RateLimitedRequestConfiguration>("sendRegistrationVerification", SendRegistrationVerification);
            writer.WriteObjectValue<RateLimitedRequestConfiguration>("sendTwoFactor", SendTwoFactor);
        }
    }
}
