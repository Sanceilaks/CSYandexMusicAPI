using System.Text.Json.Serialization;

namespace YandexMusicAPI.Models;

public class InvocationInfo
{
    /// <summary>
    /// Execution duration in milliseconds 
    /// </summary>
    [JsonPropertyName("exec-duration-millis")]
    public int? ExecDuration { get; set; }

    /// <summary>
    /// Server host name
    /// </summary>
    [JsonPropertyName("hostname")]
    public string? HostName { get; set; }

    /// <summary>
    /// ID of current request
    /// </summary>
    [JsonPropertyName("req-id")]
    public string? RequestId { get; set; }
}