// <auto-generated/>
using Askaiser.FusionAuth.Client.Api.Report.DailyActiveUser;
using Askaiser.FusionAuth.Client.Api.Report.Login;
using Askaiser.FusionAuth.Client.Api.Report.MonthlyActiveUser;
using Askaiser.FusionAuth.Client.Api.Report.Registration;
using Askaiser.FusionAuth.Client.Api.Report.Totals;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Askaiser.FusionAuth.Client.Api.Report {
    /// <summary>
    /// Builds and executes requests for operations under \api\report
    /// </summary>
    public class ReportRequestBuilder : BaseRequestBuilder {
        /// <summary>The dailyActiveUser property</summary>
        public DailyActiveUserRequestBuilder DailyActiveUser { get =>
            new DailyActiveUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The login property</summary>
        public LoginRequestBuilder Login { get =>
            new LoginRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The monthlyActiveUser property</summary>
        public MonthlyActiveUserRequestBuilder MonthlyActiveUser { get =>
            new MonthlyActiveUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The registration property</summary>
        public RegistrationRequestBuilder Registration { get =>
            new RegistrationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The totals property</summary>
        public TotalsRequestBuilder Totals { get =>
            new TotalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ReportRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/report", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ReportRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/report", rawUrl) {
        }
    }
}
