// <auto-generated/>
using Askaiser.FusionAuth.Client.Api.System.AuditLog;
using Askaiser.FusionAuth.Client.Api.System.EventLog;
using Askaiser.FusionAuth.Client.Api.System.LoginRecord;
using Askaiser.FusionAuth.Client.Api.System.Reindex;
using Askaiser.FusionAuth.Client.Api.System.VersionNamespace;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Askaiser.FusionAuth.Client.Api.System {
    /// <summary>
    /// Builds and executes requests for operations under \api\system
    /// </summary>
    public class SystemRequestBuilder : BaseRequestBuilder {
        /// <summary>The auditLog property</summary>
        public AuditLogRequestBuilder AuditLog { get =>
            new AuditLogRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The eventLog property</summary>
        public EventLogRequestBuilder EventLog { get =>
            new EventLogRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The loginRecord property</summary>
        public LoginRecordRequestBuilder LoginRecord { get =>
            new LoginRecordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reindex property</summary>
        public ReindexRequestBuilder Reindex { get =>
            new ReindexRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The version property</summary>
        public VersionRequestBuilder Version { get =>
            new VersionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new SystemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SystemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/system", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SystemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SystemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/system", rawUrl) {
        }
    }
}
