using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusinessCardWeb.Server.Models.Enums;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BusinessCardWeb.Server.Data.Entities;

/// <summary>
/// 會員工作與服務
/// </summary>
public class MemberJobAndService
{
    [Key]
    [Column(nameof(MemberJobAndService.Id), Order = 0)]
    public int Id { get; set; } 

    /// <summary>
    /// 會員編號
    /// </summary>
    [Column(nameof(MemberJobAndService.MemberId), Order = 1)]
    public int MemberId { get; set; }

    /// <summary>
    /// 分類
    /// </summary>
    [Column(nameof(MemberJobAndService.EnumType), Order = 2, TypeName = "nvarchar(50)")]
    public JobAndServiceEnum EnumType { get; set; } = JobAndServiceEnum.Company;
    
    /// <summary>
    /// 排序
    /// </summary>
    [Column(nameof(MemberJobAndService.Sort), Order = 3)]
    public int Sort { get; set; } 

     /// <summary>
    /// 內容描述標示
    /// </summary>
    [Column(nameof(MemberJobAndService.Description), Order = 4)]
    public string Description { get; set; } = string.Empty;

    public Member? Member { get; set; }
}