namespace BusinessCardWeb.Server.Data.Entities;

/// <summary>
/// 聯絡方式選項
/// </summary>
public class MemberContactOption
{
    /// <summary>
    /// 會員編號
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// Key and ID
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 內容
    /// </summary>
    public string Value { get; set; } = string.Empty;

    /// <summary>
    /// 內容簡述
    /// </summary>
    public string ValueShort { get; set; } = string.Empty;

    /// <summary>
    /// 標示
    /// </summary>
    public string FaIcon { get; set; } = string.Empty;

    /// <summary>
    /// 網址
    /// </summary>
    public string Href { get; set; } = string.Empty;

    public Member? Member { get; set; }
}