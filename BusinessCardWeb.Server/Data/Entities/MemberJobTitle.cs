using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.CodeAnalysis;

namespace BusinessCardWeb.Server.Data.Entities;

/// <summary>
/// 會員語系
/// </summary>
public class MemberJobTitle
{
    [Key]
    [Column("Id", Order = 0)]
    public int Id { get; set; } 

    /// <summary>
    /// 會員編號
    /// </summary>
    [Column("MemberId", Order = 1)]
    public int MemberId { get; set; }

    /// <summary>
    /// 公司名稱
    /// </summary>
    [Column("Company", Order = 2)]
    public string Company { get; set; } = string.Empty;

    /// <summary>
    /// 職務名稱
    /// </summary>
    [Column("JobTitle", Order = 3)]
    public string JobTitle { get; set; } = string.Empty;

     /// <summary>
    /// 標示
    /// </summary>
     [Column("FaIcon", Order = 4)]
    public string FaIcon { get; set; } = string.Empty;

    public Member? Member { get; set; }
}