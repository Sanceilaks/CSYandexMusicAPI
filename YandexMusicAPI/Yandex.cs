using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;
using YandexMusicAPI.Models.Account;

namespace YandexMusicAPI;

public class Yandex : IAsyncDisposable
{
    public readonly HttpClient HttpClient;
    public string? Token { get; set; }
    public readonly string Domain = "api.music.yandex.net";

    public Yandex(string token)
    {
        token = token.Contains("OAuth ") ? token : $"OAuth {token}";
        Token = token;

        HttpClient = new HttpClient();
        HttpClient.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(token);
        HttpClient.DefaultRequestHeaders.Add("User-Agent", "Windows 10");
    }

    public async Task AuthorizeAsync()
    {
        var result = await ApiGetRequest<Models.ApiResponse<StatusResponse, Models.Error>>($"https://{Domain}/account/status");
        if (result == null || result.IsError())
            throw new Exception($"{result!.Error!.Name} - {result!.Error!.Message}");
    }

    public async Task<string> GetRequest(string url)
    {
        var response = await HttpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }

    public ValueTask DisposeAsync()
    {
        HttpClient.Dispose();

        return ValueTask.CompletedTask;
    }

    public async Task<T?> ApiGetRequest<T>(string url) => JsonSerializer.Deserialize<T>(await GetRequest(url));
}