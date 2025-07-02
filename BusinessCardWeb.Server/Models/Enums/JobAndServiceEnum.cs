namespace BusinessCardWeb.Server.Models.Enums
{
    public enum JobAndServiceEnum
    {
        /// <summary>
        /// 其他
        /// </summary>
        Other = 0,

        /// <summary>
        /// 工作
        /// </summary>
        Company = 1,

        /// <summary>
        /// 服務
        /// </summary>
        Service = 2,
    }
    
    public static class JobAndServiceEnumExtensions
    {
        public static string GetFaIcon(this JobAndServiceEnum jobAndServiceEnum)
        {
            return jobAndServiceEnum switch
            {
                JobAndServiceEnum.Company => "fa fa-building",
                JobAndServiceEnum.Service => "fa fa-thumbs-up",
                _ => "fa fa-tags",
            };
        }
    }
}