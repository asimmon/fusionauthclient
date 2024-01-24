using System.Diagnostics.CodeAnalysis;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Askaiser.FusionAuth.Client;

[SuppressMessage("ApiDesign", "RS0026:Do not add multiple public overloads with optional parameters", Justification = "Applying Microsoft.Graph constructor patterns.")]
[SuppressMessage("ApiDesign", "RS0027:API with optional parameter(s) should have the most parameters amongst its public overloads", Justification = "Applying Microsoft.Graph constructor patterns.")]
public class FusionAuthClient : BaseFusionAuthClient, IDisposable
{
    public FusionAuthClient(string apiKey, string baseUrl)
        : this(new HttpClientRequestAdapter(CreateApiKeyAuthenticationProvider(apiKey)), baseUrl)
    {
    }

    public FusionAuthClient(HttpClient httpClient, string apiKey, string? baseUrl = null)
        : this(new HttpClientRequestAdapter(CreateApiKeyAuthenticationProvider(apiKey), httpClient: httpClient), baseUrl)
    {
    }

    public FusionAuthClient(IRequestAdapter requestAdapter, string? baseUrl = null)
        : base(InitializeRequestAdapterWithBaseUrl(requestAdapter, baseUrl))
    {
    }

    private static ApiKeyAuthenticationProvider CreateApiKeyAuthenticationProvider(string apiKey)
    {
        if (apiKey == null)
        {
            throw new ArgumentNullException(apiKey);
        }

        return new ApiKeyAuthenticationProvider(apiKey, "Authorization", ApiKeyAuthenticationProvider.KeyLocation.Header);
    }

    private static IRequestAdapter InitializeRequestAdapterWithBaseUrl(IRequestAdapter requestAdapter, string? baseUrl)
    {
        if (!string.IsNullOrEmpty(baseUrl))
        {
            requestAdapter.BaseUrl = baseUrl;
        }

        return requestAdapter;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (this.RequestAdapter is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
    }

    public void Dispose()
    {
        this.Dispose(true);
        GC.SuppressFinalize(this);
    }
}