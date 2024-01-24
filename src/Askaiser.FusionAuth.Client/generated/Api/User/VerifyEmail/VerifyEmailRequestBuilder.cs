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
namespace Askaiser.FusionAuth.Client.Api.User.VerifyEmail {
    /// <summary>
    /// Builds and executes requests for operations under \api\user\verify-email
    /// </summary>
    public class VerifyEmailRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new VerifyEmailRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VerifyEmailRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/user/verify-email{?email*,applicationId*,sendVerifyEmail*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new VerifyEmailRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VerifyEmailRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/user/verify-email{?email*,applicationId*,sendVerifyEmail*}", rawUrl) {
        }
        /// <summary>
        /// Administratively verify a user&apos;s email address. Use this method to bypass email verification for the user.  The request body will contain the userId to be verified. An API key is required when sending the userId in the request body. OR Confirms a user&apos;s email address.   The request body will contain the verificationId. You may also be required to send a one-time use code based upon your configuration. When  the tenant is configured to gate a user until their email address is verified, this procedures requires two values instead of one.  The verificationId is a high entropy value and the one-time use code is a low entropy value that is easily entered in a user interactive form. The  two values together are able to confirm a user&apos;s email address and mark the user&apos;s email address as verified.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PostAsync(VerifyEmailRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> PostAsync(VerifyEmailRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
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
        /// Re-sends the verification email to the user. OR Re-sends the verification email to the user. If the Application has configured a specific email template this will be used instead of the tenant configuration. OR Generate a new Email Verification Id to be used with the Verify Email API. This API will not attempt to send an email to the User. This API may be used to collect the verificationId for use with a third party system.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<VerifyEmailResponse?> PutAsync(Action<RequestConfiguration<VerifyEmailRequestBuilderPutQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<VerifyEmailResponse> PutAsync(Action<RequestConfiguration<VerifyEmailRequestBuilderPutQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToPutRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", Errors.CreateFromDiscriminatorValue},
                {"5XX", Errors.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<VerifyEmailResponse>(requestInfo, VerifyEmailResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Administratively verify a user&apos;s email address. Use this method to bypass email verification for the user.  The request body will contain the userId to be verified. An API key is required when sending the userId in the request body. OR Confirms a user&apos;s email address.   The request body will contain the verificationId. You may also be required to send a one-time use code based upon your configuration. When  the tenant is configured to gate a user until their email address is verified, this procedures requires two values instead of one.  The verificationId is a high entropy value and the one-time use code is a low entropy value that is easily entered in a user interactive form. The  two values together are able to confirm a user&apos;s email address and mark the user&apos;s email address as verified.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(VerifyEmailRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(VerifyEmailRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Re-sends the verification email to the user. OR Re-sends the verification email to the user. If the Application has configured a specific email template this will be used instead of the tenant configuration. OR Generate a new Email Verification Id to be used with the Verify Email API. This API will not attempt to send an email to the User. This API may be used to collect the verificationId for use with a third party system.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<VerifyEmailRequestBuilderPutQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<VerifyEmailRequestBuilderPutQueryParameters>> requestConfiguration = default) {
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
        public VerifyEmailRequestBuilder WithUrl(string rawUrl) {
            return new VerifyEmailRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class VerifyEmailRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Re-sends the verification email to the user. OR Re-sends the verification email to the user. If the Application has configured a specific email template this will be used instead of the tenant configuration. OR Generate a new Email Verification Id to be used with the Verify Email API. This API will not attempt to send an email to the User. This API may be used to collect the verificationId for use with a third party system.
        /// </summary>
        public class VerifyEmailRequestBuilderPutQueryParameters {
            /// <summary>The unique Application Id to used to resolve an application specific email template.</summary>
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
            [QueryParameter("sendVerifyEmail")]
            public string? SendVerifyEmail { get; set; }
#nullable restore
#else
            [QueryParameter("sendVerifyEmail")]
            public string SendVerifyEmail { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class VerifyEmailRequestBuilderPutRequestConfiguration : RequestConfiguration<VerifyEmailRequestBuilderPutQueryParameters> {
        }
    }
}
