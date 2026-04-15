namespace AisectOnline.Common.Clients;

//using AisectOnline.Common.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public interface IApiClient
{
    Task<Result<TResponse>> SendAsync<TRequest, TResponse>(
        HttpMethod method,
        string url,
        TRequest? body = default,
        Dictionary<string, string>? headers = null);
}

public class ApiClient : IApiClient
{
    private readonly HttpClient _http;
    private readonly ILogger<ApiClient> _logger;

    public ApiClient(HttpClient http, ILogger<ApiClient> logger)
    {
        _http = http;
        _logger = logger;
    }

    public async Task<Result<TResponse>> SendAsync<TRequest, TResponse>(
        HttpMethod method,
        string url,
        TRequest? body = default,
        Dictionary<string, string>? headers = null)
    {
        try
        {
            using var request = new HttpRequestMessage(method, url);

            // Headers
            if (headers != null)
            {
                foreach (var kv in headers)
                    request.Headers.TryAddWithoutValidation(kv.Key, kv.Value);
            }

            // Body
            if (body != null)
            {
                var json = JsonSerializer.Serialize(body);
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            }

            // Send
            using var response = await _http.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                _logger.LogWarning("External API call to {Url} returned {Status}: {Content}", url, response.StatusCode, content);
                return Result<TResponse>.Failure($"API call failed: {response.StatusCode}");
            }

            var result = JsonSerializer.Deserialize<TResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            if (result == null)
                return Result<TResponse>.Failure("Deserialization returned null");

            return Result<TResponse>.Success(result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error calling external API {Url}", url);
            return Result<TResponse>.Failure(ex.Message);
        }
    }
}
