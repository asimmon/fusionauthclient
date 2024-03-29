// <auto-generated/>
using Askaiser.FusionAuth.Client.Api.Entity.Grant;
using Askaiser.FusionAuth.Client.Api.Entity.Item;
using Askaiser.FusionAuth.Client.Api.Entity.Search;
using Askaiser.FusionAuth.Client.Api.Entity.TypeNamespace;
using Askaiser.FusionAuth.Client.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Askaiser.FusionAuth.Client.Api.Entity {
    /// <summary>
    /// Builds and executes requests for operations under \api\entity
    /// </summary>
    public class EntityRequestBuilder : BaseRequestBuilder {
        /// <summary>The grant property</summary>
        public GrantRequestBuilder Grant { get =>
            new GrantRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The search property</summary>
        public SearchRequestBuilder Search { get =>
            new SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The type property</summary>
        public TypeRequestBuilder Type { get =>
            new TypeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Askaiser.FusionAuth.Client.api.entity.item collection</summary>
        /// <param name="position">The Id of the Entity.</param>
        public WithEntityItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("entityId", position);
            return new WithEntityItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new EntityRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EntityRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/entity", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new EntityRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EntityRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/entity", rawUrl) {
        }
        /// <summary>
        /// Creates an Entity. You can optionally specify an Id for the Entity. If not provided one will be generated.
        /// </summary>
        /// <param name="body">Entity API request object.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<EntityResponse?> PostAsync(EntityRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<EntityResponse> PostAsync(EntityRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", Errors.CreateFromDiscriminatorValue},
                {"5XX", Errors.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<EntityResponse>(requestInfo, EntityResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates an Entity. You can optionally specify an Id for the Entity. If not provided one will be generated.
        /// </summary>
        /// <param name="body">Entity API request object.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(EntityRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(EntityRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        public EntityRequestBuilder WithUrl(string rawUrl) {
            return new EntityRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class EntityRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
