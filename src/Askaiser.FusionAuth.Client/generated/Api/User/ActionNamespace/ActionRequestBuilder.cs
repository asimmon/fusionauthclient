// <auto-generated/>
using Askaiser.FusionAuth.Client.Api.User.ActionNamespace.Item;
using Askaiser.FusionAuth.Client.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Askaiser.FusionAuth.Client.Api.User.ActionNamespace {
    /// <summary>
    /// Builds and executes requests for operations under \api\user\action
    /// </summary>
    public class ActionRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Askaiser.FusionAuth.Client.api.user.action.item collection</summary>
        /// <param name="position">The action id of the action to cancel.</param>
        public WithActionItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("actionId", position);
            return new WithActionItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ActionRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/user/action{?userId*,preventingLogin*,active*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ActionRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/user/action{?userId*,preventingLogin*,active*}", rawUrl) {
        }
        /// <summary>
        /// Retrieves all the actions for the user with the given Id that are currently preventing the User from logging in. OR Retrieves all the actions for the user with the given Id. This will return all time based actions that are active, and inactive as well as non-time based actions. OR Retrieves all the actions for the user with the given Id that are currently active. An active action means one that is time based and has not been canceled, and has not ended. OR Retrieves all the actions for the user with the given Id that are currently inactive. An inactive action means one that is time based and has been canceled or has expired, or is not time based.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ActionResponse?> GetAsync(Action<RequestConfiguration<ActionRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ActionResponse> GetAsync(Action<RequestConfiguration<ActionRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", Errors.CreateFromDiscriminatorValue},
                {"5XX", Errors.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ActionResponse>(requestInfo, ActionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Takes an action on a user. The user being actioned is called the &quot;actionee&quot; and the user taking the action is called the &quot;actioner&quot;. Both user ids are required in the request object.
        /// </summary>
        /// <param name="body">The user action request object.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ActionResponse?> PostAsync(ActionRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ActionResponse> PostAsync(ActionRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", Errors.CreateFromDiscriminatorValue},
                {"5XX", Errors.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ActionResponse>(requestInfo, ActionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves all the actions for the user with the given Id that are currently preventing the User from logging in. OR Retrieves all the actions for the user with the given Id. This will return all time based actions that are active, and inactive as well as non-time based actions. OR Retrieves all the actions for the user with the given Id that are currently active. An active action means one that is time based and has not been canceled, and has not ended. OR Retrieves all the actions for the user with the given Id that are currently inactive. An inactive action means one that is time based and has been canceled or has expired, or is not time based.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ActionRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ActionRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Takes an action on a user. The user being actioned is called the &quot;actionee&quot; and the user taking the action is called the &quot;actioner&quot;. Both user ids are required in the request object.
        /// </summary>
        /// <param name="body">The user action request object.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ActionRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ActionRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        public ActionRequestBuilder WithUrl(string rawUrl) {
            return new ActionRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves all the actions for the user with the given Id that are currently preventing the User from logging in. OR Retrieves all the actions for the user with the given Id. This will return all time based actions that are active, and inactive as well as non-time based actions. OR Retrieves all the actions for the user with the given Id that are currently active. An active action means one that is time based and has not been canceled, and has not ended. OR Retrieves all the actions for the user with the given Id that are currently inactive. An inactive action means one that is time based and has been canceled or has expired, or is not time based.
        /// </summary>
        public class ActionRequestBuilderGetQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("active")]
            public string? Active { get; set; }
#nullable restore
#else
            [QueryParameter("active")]
            public string Active { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("preventingLogin")]
            public string? PreventingLogin { get; set; }
#nullable restore
#else
            [QueryParameter("preventingLogin")]
            public string PreventingLogin { get; set; }
#endif
            /// <summary>The Id of the user to fetch the actions for.</summary>
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
        public class ActionRequestBuilderGetRequestConfiguration : RequestConfiguration<ActionRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ActionRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}