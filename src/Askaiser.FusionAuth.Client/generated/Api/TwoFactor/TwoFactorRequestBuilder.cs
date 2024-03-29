// <auto-generated/>
using Askaiser.FusionAuth.Client.Api.TwoFactor.Login;
using Askaiser.FusionAuth.Client.Api.TwoFactor.Secret;
using Askaiser.FusionAuth.Client.Api.TwoFactor.Send;
using Askaiser.FusionAuth.Client.Api.TwoFactor.Start;
using Askaiser.FusionAuth.Client.Api.TwoFactor.Status;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Askaiser.FusionAuth.Client.Api.TwoFactor {
    /// <summary>
    /// Builds and executes requests for operations under \api\two-factor
    /// </summary>
    public class TwoFactorRequestBuilder : BaseRequestBuilder {
        /// <summary>The login property</summary>
        public LoginRequestBuilder Login { get =>
            new LoginRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The secret property</summary>
        public SecretRequestBuilder Secret { get =>
            new SecretRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The send property</summary>
        public SendRequestBuilder Send { get =>
            new SendRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The start property</summary>
        public StartRequestBuilder Start { get =>
            new StartRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The status property</summary>
        public StatusRequestBuilder Status { get =>
            new StatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new TwoFactorRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TwoFactorRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/two-factor", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new TwoFactorRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TwoFactorRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/two-factor", rawUrl) {
        }
    }
}
