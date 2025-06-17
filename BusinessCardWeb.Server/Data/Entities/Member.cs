using System.ComponentModel.DataAnnotations;

namespace BusinessCardWeb.Server.Data.Entities;

/// <summary>
/// 會員
/// </summary>
public class Member
{
    /// <summary>
    /// 會員編號
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 姓名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 電子郵件
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// 職位
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// 電話號碼
    /// </summary>
    public string PhoneNumber { get; set; } = string.Empty;

    /// <summary>
    /// 地址
    /// </summary>
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// 個人簡介
    /// </summary>
    public string ProfileSumarry { get; set; } = string.Empty;

    /// <summary>
    /// 照片(路徑)
    /// </summary>
    public string? PictureUrl { get; set; }

    public string? FaceBook { get; set; }

    public string? IG { get; set; }

    public string? LinkedIn { get; set; }

    public string? Twitter { get; set; }

    /// <summary>
    /// 建立日期 UTC+0
    /// </summary>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// 修改日期 UTC+0
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public List<MemberLocale>? Locales { get; set; }
}
