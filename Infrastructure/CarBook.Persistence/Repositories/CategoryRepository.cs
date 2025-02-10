using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;

namespace CarBook.Persistence.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(CarBookContext context) : base(context)
        {
        }

        public async Task ChangeShownStatus(int id)
        {
            var value = await _context.Categories.FindAsync(id);
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
            var value = await _context.Categories.FindAsync(id);
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