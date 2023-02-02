namespace YandexMusicAPI.Models.Account;

public class Permissions
{
    // TODO Comments

    public DateTime? Until { get; set; }
    public List<string>? Values { get; set; }
    public List<string?>? Default { get; set; }
}