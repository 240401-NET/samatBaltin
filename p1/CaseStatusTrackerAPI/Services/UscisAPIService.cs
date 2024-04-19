using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CaseStatusTrackerAPI.Services;

public class UscisApiService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public UscisApiService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task<string> GetAccessTokenAsync()
    {
        string _tokenUrl = _configuration["UscisApi:TokenUrl"];
        string _clientId = _configuration["UscisApi:ClientId"];
        string _clientSecret = _configuration["UscisApi:ClientSecret"];
        
        var requestContent = new StringContent($"client_id={Uri.EscapeDataString(_clientId)}&client_secret={Uri.EscapeDataString(_clientSecret)}&grant_type=client_credentials", Encoding.UTF8, "application/x-www-form-urlencoded");

        try {
            var response = await _httpClient.PostAsync(_tokenUrl, requestContent);
            response.EnsureSuccessStatusCode();

            // Log the response content for inspection
            var responseContent = await response.Content.ReadAsStringAsync();

            // Extracting access token from the response content
            using (JsonDocument document = JsonDocument.Parse(responseContent)) {
                JsonElement root = document.RootElement;
                if (root.TryGetProperty("access_token", out JsonElement accessTokenElement)){
                    string accessToken = accessTokenElement.GetString();
                    return accessToken;
                } else {
                    // Log an error if the access_token property is not found
                    Console.WriteLine("Access token not found in the response.");
                    throw new InvalidOperationException("Access token not found in the response.");
                }
            }
        }
        catch (HttpRequestException ex) {
            // Log the exception
            Console.WriteLine($"Error while obtaining access token: {ex.Message}");
            throw;
        }
    }

    public async Task<string> GetCaseStatusAsync(string caseId) {
        var accessToken = await GetAccessTokenAsync();
        // Include the access token in the request headers
        _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
        var endpointUrl = $"https://api-int.uscis.gov/case-status/{caseId}";
        var response = await _httpClient.GetAsync(endpointUrl);
        response.EnsureSuccessStatusCode();
        var responseContent = await response.Content.ReadAsStringAsync();
        return responseContent;
    }
}