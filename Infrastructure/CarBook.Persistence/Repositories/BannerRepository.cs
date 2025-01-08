using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;

namespace CarBook.Persistence.Repositories
{
    public class BannerRepository : Repository<Banner>, IBannerRepository
    {
        public BannerRepository(CarBookContext context) : base(context) 
        {
        }

        public async Task ChangeStatusAsync(int id)
        {
            var value = await _context.Banners.FindAsync(id);
            if (value.IsActive == true)
            {
                value.IsActive = false;
            }
            else
            {
                value.IsActive = true;
            }
            _context.Update(value);
            _context.SaveChangesAsync();
        }

        public async Task DontShowOnHome(int id)
        {
            var value = await _context.Banners.FindAsync(id);
            value.IsShown = false;
            _context.SaveChangesAsync();
        }

        public async Task ShowOnHome(int id)
        {
            var value = await _context.Banners.FindAsync(id);
            value.IsShown = true;
            _context.SaveChangesAsync();
        }
    }
}