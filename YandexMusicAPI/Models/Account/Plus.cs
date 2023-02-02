using System.Text.Json.Serialization;

namespace YandexMusicAPI.Models.Account;

public class Plus
{
    [JsonPropertyName("hasPlus")]
    public bool? HasPlus { get; set; }

    [JsonPropertyName("isTutorialCompleted")]
    public bool? IsTutorialCompleted { get; set; }
}