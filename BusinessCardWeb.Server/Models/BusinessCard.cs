namespace BusinessCardWeb.Server.Models
{
    /// <summary>
    /// 名片
    /// </summary>
    public class BusinessCard(string name, string email)
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; } = name;

        /// <summary>
        /// 電子郵件
        /// </summary>
        public string Email { get; set; } = email;

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
        /// 社群清單
        /// </summary>
        public Dictionary<string, string> SocialMedia { get; set; } = new Dictionary<string, string>();
    }
}
