using BusinessCardWeb.Server.BusinessLogics.Interface;
using BusinessCardWeb.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessCardWeb.Server.BusinessLogics
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
            var user = await _db.Members
                .Include(member => member.Locales)
                .Include(member => member.ContactOptions)
                .FirstOrDefaultAsync(member => member.Id == userId);

            if (user == null)
            {
                throw new ArgumentException($"User with ID {userId} not found.");
            }

            return new BusinessCard(name: user.Name)
            {
                ProfilePictureUrl = user.PictureUrl ?? string.Empty,
                Locales = user.Locales.ToDictionary(
                    locale => locale.Locale,
                    locale => new Locale(locale.Name, locale.Credits, locale.Role)),                    
                ContactOptions = user.ContactOptions.Select(option => new ContactOption
                {
                    Id = option.Name,
                    Value = option.Value,
                    ValueShort = option.ValueShort,
                    FaIcon = option.FaIcon,
                    href = option.Href
                }).ToList(),
            };
        }
    }
}
