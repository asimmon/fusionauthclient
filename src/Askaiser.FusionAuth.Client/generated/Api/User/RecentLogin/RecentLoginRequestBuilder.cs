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
namespace Askaiser.FusionAuth.Client.Api.User.RecentLogin {
    /// <summary>
    /// Builds and executes requests for operations under \api\user\recent-login
    /// </summary>
    public class RecentLoginRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new RecentLoginRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RecentLoginRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/user/recent-login{?offset*,limit*,userId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new RecentLoginRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RecentLoginRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/user/recent-login{?offset*,limit*,userId*}", rawUrl) {
        }
        /// <summary>
        /// Retrieves the last number of login records. OR Retrieves the last number of login records for a user.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<RecentLoginResponse?> GetAsync(Action<RequestConfiguration<RecentLoginRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<RecentLoginResponse> GetAsync(Action<RequestConfiguration<RecentLoginRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", Errors.CreateFromDiscriminatorValue},
                {"5XX", Errors.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<RecentLoginResponse>(requestInfo, RecentLoginResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves the last number of login records. OR Retrieves the last number of login records for a user.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RecentLoginRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RecentLoginRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RecentLoginRequestBuilder WithUrl(string rawUrl) {
            return new RecentLoginRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves the last number of login records. OR Retrieves the last number of login records for a user.
        /// </summary>
        public class RecentLoginRequestBuilderGetQueryParameters {
            /// <summary>(Optional, defaults to 10) The number of records to retrieve.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("limit")]
            public string? Limit { get; set; }
#nullable restore
#else
            [QueryParameter("limit")]
            public string Limit { get; set; }
#endif
            /// <summary>The initial record. e.g. 0 is the last login, 100 will be the 100th most recent login.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("offset")]
            public string? Offset { get; set; }
#nullable restore
#else
            [QueryParameter("offset")]
            public string Offset { get; set; }
#endif
            /// <summary>The Id of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("userId")]
            public string? UserId { get; set; }
#nullable restore
#else
            [QueryParameter("userId")]
            public string UserId { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class RecentLoginRequestBuilderGetRequestConfiguration : RequestConfiguration<RecentLoginRequestBuilderGetQueryParameters> {
        }
    }
}