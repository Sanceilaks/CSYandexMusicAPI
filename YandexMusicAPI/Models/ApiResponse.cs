using System.Text.Json.Serialization;

namespace YandexMusicAPI.Models;

public class ApiResponse<T, E>
{
    /// <summary>
    /// Info about current execution
    /// </summary>
    [JsonPropertyName("invocationInfo")]
    public InvocationInfo? InvocationInfo { get; set; }

    /// <summary>
    /// Execution result
    /// </summary>
    [JsonPropertyName("result")]
    public T? Result { get; set; }

    /// <summary>
    /// Execution error
    /// </summary>
    [JsonPropertyName("error")]
    public E? Error { get; set; }

    public bool IsError() => Error != null;
    public bool IsSuccess() => Result != null;
}