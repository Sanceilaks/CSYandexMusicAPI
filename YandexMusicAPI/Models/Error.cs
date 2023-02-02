using System.Text.Json.Serialization;

namespace YandexMusicAPI.Models;

public class Error
{
    /// <summary>
    /// Error name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Error message
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}