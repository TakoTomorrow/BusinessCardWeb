namespace BusinessCardWeb.Server.Data.Entities;

/// <summary>
/// 會員
/// </summary>
public class Member
{
    /// <summary>
    /// 會員編號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 會員名稱
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 電子郵件
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// 電話號碼
    /// </summary>
    public string PhoneNumber { get; set; } = string.Empty;

    /// <summary>
    /// 地址
    /// </summary>
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// 出生日期
    /// </summary>
    public DateTime DateOfBirth { get; set; }

    /// <summary>
    /// 個人簡介
    /// </summary>
    public string ProfileSumarry { get; set; } = string.Empty;

    /// <summary>
    /// 照片(路徑)
    /// </summary>
    /// <value></value>
    public string? PictureUrl { get; set; }
}
