using System.Text.Json.Serialization;

namespace YandexMusicAPI.Models.Account;

public class StatusResponse
{
    /// <summary>
    /// Account information
    /// </summary>
    public Account? Account { get; set; }
    public Permissions? Permissions { get; set; }
    public Subscription? Subscription { get; set; }
    public bool? SubEditor { get; set; }
    public long? SubEditorLevel { get; set; }
    public bool? PretrialActive { get; set; }
    public Plus? Plus { get; set; }
    public string? DefaultEmail { get; set; }
    public BarBelow? BarBelow { get; set; }
}