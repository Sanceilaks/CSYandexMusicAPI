namespace YandexMusicAPI;

public class Yandex
{
    public string? Token { get; set; }
    public Yandex(string token)
    {
        token = token.Contains("OAuth ") ? token : $"OAuth {token}";
        Token = token;
    }

    public async Task<bool> AuthorizeAsync()
    {
        return false;
    }
}