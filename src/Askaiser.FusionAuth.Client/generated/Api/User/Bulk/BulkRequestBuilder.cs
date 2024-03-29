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
namespace Askaiser.FusionAuth.Client.Api.User.Bulk {
    /// <summary>
    /// Builds and executes requests for operations under \api\user\bulk
    /// </summary>
    public class BulkRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new BulkRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BulkRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/user/bulk{?userIds*,dryRun*,hardDelete*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new BulkRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BulkRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/user/bulk{?userIds*,dryRun*,hardDelete*}", rawUrl) {
        }
        /// <summary>
        /// Deactivates the users with the given ids. OR Deletes the users with the given ids, or users matching the provided JSON query or queryString. The order of preference is ids, query and then queryString, it is recommended to only provide one of the three for the request.  This method can be used to deactivate or permanently delete (hard-delete) users based upon the hardDelete boolean in the request body. Using the dryRun parameter you may also request the result of the action without actually deleting or deactivating any users.
        /// </summary>
        /// <param name="body">User API delete request object.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<UserDeleteResponse?> DeleteAsUserDeleteResponseAsync(UserDeleteRequest body, Action<RequestConfiguration<BulkRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<UserDeleteResponse> DeleteAsUserDeleteResponseAsync(UserDeleteRequest body, Action<RequestConfiguration<BulkRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", Errors.CreateFromDiscriminatorValue},
                {"5XX", Errors.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<UserDeleteResponse>(requestInfo, UserDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deactivates the users with the given ids. OR Deletes the users with the given ids, or users matching the provided JSON query or queryString. The order of preference is ids, query and then queryString, it is recommended to only provide one of the three for the request.  This method can be used to deactivate or permanently delete (hard-delete) users based upon the hardDelete boolean in the request body. Using the dryRun parameter you may also request the result of the action without actually deleting or deactivating any users.
        /// </summary>
        /// <param name="body">User API delete request object.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use DeleteAsUserDeleteResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<UserResponse?> DeleteAsync(UserDeleteRequest body, Action<RequestConfiguration<BulkRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<UserResponse> DeleteAsync(UserDeleteRequest body, Action<RequestConfiguration<BulkRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", Errors.CreateFromDiscriminatorValue},
                {"5XX", Errors.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<UserResponse>(requestInfo, UserResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deactivates the users with the given ids. OR Deletes the users with the given ids, or users matching the provided JSON query or queryString. The order of preference is ids, query and then queryString, it is recommended to only provide one of the three for the request.  This method can be used to deactivate or permanently delete (hard-delete) users based upon the hardDelete boolean in the request body. Using the dryRun parameter you may also request the result of the action without actually deleting or deactivating any users.
        /// </summary>
        /// <param name="body">User API delete request object.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(UserDeleteRequest body, Action<RequestConfiguration<BulkRequestBuilderDeleteQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(UserDeleteRequest body, Action<RequestConfiguration<BulkRequestBuilderDeleteQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public BulkRequestBuilder WithUrl(string rawUrl) {
            return new BulkRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Deactivates the users with the given ids. OR Deletes the users with the given ids, or users matching the provided JSON query or queryString. The order of preference is ids, query and then queryString, it is recommended to only provide one of the three for the request.  This method can be used to deactivate or permanently delete (hard-delete) users based upon the hardDelete boolean in the request body. Using the dryRun parameter you may also request the result of the action without actually deleting or deactivating any users.
        /// </summary>
        public class BulkRequestBuilderDeleteQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("dryRun")]
            public string? DryRun { get; set; }
#nullable restore
#else
            [QueryParameter("dryRun")]
            public string DryRun { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("hardDelete")]
            public string? HardDelete { get; set; }
#nullable restore
#else
            [QueryParameter("hardDelete")]
            public string HardDelete { get; set; }
#endif
            /// <summary>The ids of the users to deactivate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("userIds")]
            public string? UserIds { get; set; }
#nullable restore
#else
            [QueryParameter("userIds")]
            public string UserIds { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class BulkRequestBuilderDeleteRequestConfiguration : RequestConfiguration<BulkRequestBuilderDeleteQueryParameters> {
        }
    }
}
