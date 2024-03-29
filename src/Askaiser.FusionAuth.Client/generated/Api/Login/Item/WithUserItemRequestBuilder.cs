// <auto-generated/>
using Askaiser.FusionAuth.Client.Api.Login.Item.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Askaiser.FusionAuth.Client.Api.Login.Item {
    /// <summary>
    /// Builds and executes requests for operations under \api\login\{userId}
    /// </summary>
    public class WithUserItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Askaiser.FusionAuth.Client.api.login.item.item collection</summary>
        /// <param name="position">The Id of the application that they logged into.</param>
        public WithApplicationItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("applicationId", position);
            return new WithApplicationItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new WithUserItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUserItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/login/{userId}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithUserItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUserItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/login/{userId}", rawUrl) {
        }
    }
}
