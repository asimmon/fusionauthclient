// <auto-generated/>
using Askaiser.FusionAuth.Client.Api.User.ChangePassword.Item;
using Askaiser.FusionAuth.Client.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Askaiser.FusionAuth.Client.Api.User.ChangePassword {
    /// <summary>
    /// Builds and executes requests for operations under \api\user\change-password
    /// </summary>
    public class ChangePasswordRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Askaiser.FusionAuth.Client.api.user.changePassword.item collection</summary>
        /// <param name="position">The change password Id used to find the user. This value is generated by FusionAuth once the change password workflow has been initiated.</param>
        public WithChangePasswordItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("changePasswordId", position);
            return new WithChangePasswordItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ChangePasswordRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChangePasswordRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/user/change-password{?loginId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ChangePasswordRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChangePasswordRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/user/change-password{?loginId*}", rawUrl) {
        }
        /// <summary>
        /// Check to see if the user must obtain a Trust Request Id in order to complete a change password request. When a user has enabled Two-Factor authentication, before you are allowed to use the Change Password API to change your password, you must obtain a Trust Request Id by completing a Two-Factor Step-Up authentication.  An HTTP status code of 400 with a general error code of [TrustTokenRequired] indicates that a Trust Token is required to make a POST request to this API. OR Check to see if the user must obtain a Trust Token Id in order to complete a change password request. When a user has enabled Two-Factor authentication, before you are allowed to use the Change Password API to change your password, you must obtain a Trust Token by completing a Two-Factor Step-Up authentication.  An HTTP status code of 400 with a general error code of [TrustTokenRequired] indicates that a Trust Token is required to make a POST request to this API.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<ChangePasswordRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<ChangePasswordRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", Errors.CreateFromDiscriminatorValue},
                {"5XX", Errors.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Changes a user&apos;s password using their identity (login id and password). Using a loginId instead of the changePasswordId bypasses the email verification and allows a password to be changed directly without first calling the #forgotPassword method.
        /// </summary>
        /// <param name="body">Change password request object.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PostAsync(ChangePasswordRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> PostAsync(ChangePasswordRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
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
        /// Check to see if the user must obtain a Trust Request Id in order to complete a change password request. When a user has enabled Two-Factor authentication, before you are allowed to use the Change Password API to change your password, you must obtain a Trust Request Id by completing a Two-Factor Step-Up authentication.  An HTTP status code of 400 with a general error code of [TrustTokenRequired] indicates that a Trust Token is required to make a POST request to this API. OR Check to see if the user must obtain a Trust Token Id in order to complete a change password request. When a user has enabled Two-Factor authentication, before you are allowed to use the Change Password API to change your password, you must obtain a Trust Token by completing a Two-Factor Step-Up authentication.  An HTTP status code of 400 with a general error code of [TrustTokenRequired] indicates that a Trust Token is required to make a POST request to this API.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ChangePasswordRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ChangePasswordRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Changes a user&apos;s password using their identity (login id and password). Using a loginId instead of the changePasswordId bypasses the email verification and allows a password to be changed directly without first calling the #forgotPassword method.
        /// </summary>
        /// <param name="body">Change password request object.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ChangePasswordRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ChangePasswordRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ChangePasswordRequestBuilder WithUrl(string rawUrl) {
            return new ChangePasswordRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Check to see if the user must obtain a Trust Request Id in order to complete a change password request. When a user has enabled Two-Factor authentication, before you are allowed to use the Change Password API to change your password, you must obtain a Trust Request Id by completing a Two-Factor Step-Up authentication.  An HTTP status code of 400 with a general error code of [TrustTokenRequired] indicates that a Trust Token is required to make a POST request to this API. OR Check to see if the user must obtain a Trust Token Id in order to complete a change password request. When a user has enabled Two-Factor authentication, before you are allowed to use the Change Password API to change your password, you must obtain a Trust Token by completing a Two-Factor Step-Up authentication.  An HTTP status code of 400 with a general error code of [TrustTokenRequired] indicates that a Trust Token is required to make a POST request to this API.
        /// </summary>
        public class ChangePasswordRequestBuilderGetQueryParameters {
            /// <summary>The loginId of the User that you intend to change the password for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("loginId")]
            public string? LoginId { get; set; }
#nullable restore
#else
            [QueryParameter("loginId")]
            public string LoginId { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ChangePasswordRequestBuilderGetRequestConfiguration : RequestConfiguration<ChangePasswordRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ChangePasswordRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}