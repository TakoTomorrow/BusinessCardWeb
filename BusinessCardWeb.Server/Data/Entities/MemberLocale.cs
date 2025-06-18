namespace BusinessCardWeb.Server.Data.Entities;

/// <summary>
/// 會員語系
/// </summary>
public class MemberLocale
{
    /// <summary>
    /// 會員編號
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 語系
    /// </summary>
    public string Locale { get; set; } = string.Empty;

    /// <summary>
    /// 名稱
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 貢獻
    /// </summary>
    public string Credits { get; set; } = string.Empty;

    /// <summary>
    /// 角色
    /// </summary>
    public string Role { get; set; } = string.Empty;

    public Member? Member { get; set; }
}