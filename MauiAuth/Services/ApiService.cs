using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;

namespace MauiAuth.Services;

public class ApiService
{
    private readonly KeycloakClient keycloakClient;
    private HttpClient httpClient;

    public ApiService(KeycloakClient keycloakClient, IConfiguration config)
    {
        httpClient = new HttpClient();
        //httpClient.BaseAddress = new Uri(config["API_ADDRESS"]);
        httpClient.BaseAddress = new Uri("https://mauiauth22.azurewebsites.net");
        this.keycloakClient = keycloakClient;
    }

    public async Task<string> GetAsync(string endpoint)
    {
        httpClient.DefaultRequestHeaders.Clear();
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", keycloakClient.IdentityToken);

        var response = await httpClient.GetAsync(endpoint);
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadAsStringAsync();
        }

        return response.ToString();
    }

    public async Task<string> GetAsyncWithoutAuthorization(string endpoint)
    {
        httpClient.DefaultRequestHeaders.Clear();

        var response = await httpClient.GetAsync(endpoint);
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadAsStringAsync();
        }

        return response.ToString();
    }
}
