// <auto-generated/>
using Askaiser.FusionAuth.Client.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Askaiser.FusionAuth.Client.Api.User.VerifyRegistration {
    /// <summary>
    /// Builds and executes requests for operations under \api\user\verify-registration
    /// </summary>
    public class VerifyRegistrationRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new VerifyRegistrationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VerifyRegistrationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/user/verify-registration{?email*,sendVerifyPasswordEmail*,applicationId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new VerifyRegistrationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VerifyRegistrationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/user/verify-registration{?email*,sendVerifyPasswordEmail*,applicationId*}", rawUrl) {
        }
        /// <summary>
        /// Confirms a user&apos;s registration.   The request body will contain the verificationId. You may also be required to send a one-time use code based upon your configuration. When  the application is configured to gate a user until their registration is verified, this procedures requires two values instead of one.  The verificationId is a high entropy value and the one-time use code is a low entropy value that is easily entered in a user interactive form. The  two values together are able to confirm a user&apos;s registration and mark the user&apos;s registration as verified.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PostAsync(VerifyRegistrationRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> PostAsync(VerifyRegistrationRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", Errors.CreateFromDiscriminatorValue},
                {"5XX", Errors.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Generate a new Application Registration Verification Id to be used with the Verify Registration API. This API will not attempt to send an email to the User. This API may be used to collect the verificationId for use with a third party system. OR Re-sends the application registration verification email to the user.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<VerifyRegistrationResponse?> PutAsync(Action<RequestConfiguration<VerifyRegistrationRequestBuilderPutQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<VerifyRegistrationResponse> PutAsync(Action<RequestConfiguration<VerifyRegistrationRequestBuilderPutQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToPutRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<VerifyRegistrationResponse>(requestInfo, VerifyRegistrationResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Confirms a user&apos;s registration.   The request body will contain the verificationId. You may also be required to send a one-time use code based upon your configuration. When  the application is configured to gate a user until their registration is verified, this procedures requires two values instead of one.  The verificationId is a high entropy value and the one-time use code is a low entropy value that is easily entered in a user interactive form. The  two values together are able to confirm a user&apos;s registration and mark the user&apos;s registration as verified.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(VerifyRegistrationRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(VerifyRegistrationRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Generate a new Application Registration Verification Id to be used with the Verify Registration API. This API will not attempt to send an email to the User. This API may be used to collect the verificationId for use with a third party system. OR Re-sends the application registration verification email to the user.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<VerifyRegistrationRequestBuilderPutQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<VerifyRegistrationRequestBuilderPutQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public VerifyRegistrationRequestBuilder WithUrl(string rawUrl) {
            return new VerifyRegistrationRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class VerifyRegistrationRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Generate a new Application Registration Verification Id to be used with the Verify Registration API. This API will not attempt to send an email to the User. This API may be used to collect the verificationId for use with a third party system. OR Re-sends the application registration verification email to the user.
        /// </summary>
        public class VerifyRegistrationRequestBuilderPutQueryParameters {
            /// <summary>The Id of the application to be verified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("applicationId")]
            public string? ApplicationId { get; set; }
#nullable restore
#else
            [QueryParameter("applicationId")]
            public string ApplicationId { get; set; }
#endif
            /// <summary>The email address of the user that needs a new verification email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("email")]
            public string? Email { get; set; }
#nullable restore
#else
            [QueryParameter("email")]
            public string Email { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sendVerifyPasswordEmail")]
            public string? SendVerifyPasswordEmail { get; set; }
#nullable restore
#else
            [QueryParameter("sendVerifyPasswordEmail")]
            public string SendVerifyPasswordEmail { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class VerifyRegistrationRequestBuilderPutRequestConfiguration : RequestConfiguration<VerifyRegistrationRequestBuilderPutQueryParameters> {
        }
    }
}
