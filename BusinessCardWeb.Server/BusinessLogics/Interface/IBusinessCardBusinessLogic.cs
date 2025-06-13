using BusinessCardWeb.Server.Models;

namespace BusinessCardWeb.Server.BusinessLogics.Interface
{
    public interface IBusinessCardBusinessLogic
    {
        Task<BusinessCard> GetBusinessCardAsync(int userId);
    }
}
