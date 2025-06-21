namespace BusinessCardWeb.Server.Models;

public class ResponseData<T>
{
    /// <summary>
    /// 是否成功
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 錯誤訊息
    /// </summary>
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// 資料
    /// </summary>
    public T? Data { get; set; }
}