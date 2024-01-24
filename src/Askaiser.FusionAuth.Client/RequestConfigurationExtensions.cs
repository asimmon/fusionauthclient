using Microsoft.Kiota.Abstractions;

namespace Askaiser.FusionAuth.Client;

public static class RequestConfigurationExtensions
{
    public static void WithTenantId<T>(this RequestConfiguration<T> requestConfiguration, string tenantId)
        where T : class, new()
    {
        if (requestConfiguration == null)
        {
            throw new ArgumentNullException(nameof(requestConfiguration));
        }

        if (string.IsNullOrEmpty(tenantId))
        {
            throw new ArgumentNullException(nameof(tenantId));
        }

        requestConfiguration.Headers.TryAdd("X-FusionAuth-TenantId", tenantId);
    }
}