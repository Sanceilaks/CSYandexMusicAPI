using System.Text.Json.Serialization;

namespace YandexMusicAPI.Models.Account;

public class Subscription
{
    [JsonPropertyName("hadAnySubscription")]
    public bool HadAnySubscription { get; set; }

    [JsonPropertyName("canStartTrial")]
    public bool CanStartTrial { get; set; }

    [JsonPropertyName("mcdonalds")]
    public bool McDonalds { get; set; }
}