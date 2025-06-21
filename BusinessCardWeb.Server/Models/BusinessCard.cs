using System.Collections.Generic;

namespace BusinessCardWeb.Server.Models
{
    /// <summary>
    /// 名片
    /// </summary>
    public class BusinessCard(string name)
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; } = name;

        /// <summary>
        /// 大頭貼網址
        /// summary>
        public string ProfilePictureUrl { get; set; } = string.Empty;
        
        /// <summary>
        /// 語系清單
        /// </summary>
        public Dictionary<string, Locale> Locales { get; set; } = new Dictionary<string, Locale>();

        /// <summary>
        /// 聯絡方式選項清單
        /// </summary>
        public List<ContactOption> ContactOptions { get; set; } = new List<ContactOption>();
    }

    public class ContactOption
    {
        public string Id { get; set; } = string.Empty;
 
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
        public string href { get; set; } = string.Empty;
    }

    public class Locale(string _name, string _credits, string _role)
    {
        /// <summary>
        /// 名稱
        /// </summary>
        public string Name { get; set; } = _name;

        /// <summary>
        /// 貢獻
        /// </summary>
        public string Credits { get; set; } = _credits;

        /// <summary>
        /// 角色
        /// </summary>
        public string Role { get; set; } = _role;
    }    
}
