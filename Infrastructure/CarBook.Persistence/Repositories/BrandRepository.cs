using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;

namespace CarBook.Persistence.Repositories
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public BrandRepository(CarBookContext context) : base(context)
        {
        }

        public async Task ChangeShownStatus(int id)
        {
            var value = await _context.Brands.FindAsync(id);
            if (value.IsShown == true)
            {
                value.IsShown = false;
            }
            else
            {
                value.IsShown = true;
            }
            _context.Update(value);
            _context.SaveChangesAsync();
        }

        public async Task ChangeStatus(int id)
        {
            var value = await _context.Brands.FindAsync(id);
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
    }
}