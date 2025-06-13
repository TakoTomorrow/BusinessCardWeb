using BusinessCardWeb.Server.BusinessLogics.Interface;
using BusinessCardWeb.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessCardWeb.Server.Controllers
{
    public class BusinessCardBusinessLogic : IBusinessCardBusinessLogic
    {
        public BusinessCardBusinessLogic(BusinessCardContext db)
        {
            _db = db;
        }

        private readonly BusinessCardContext _db;

        // 取得名片        
        public async Task<BusinessCard> GetBusinessCardAsync(int userId)
        {
            var user = await _db.Members.FirstOrDefaultAsync(member => member.Id == userId);

            if (user == null)
            {
                throw new ArgumentException($"User with ID {userId} not found.");
            }

            return new BusinessCard(name: user.Name, email: user.Email);
        }
    }
}
