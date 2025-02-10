using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(CarBookContext context) : base(context)
        {
        }

        public async Task ChangeShownStatus(int id)
        {
            var value = await _context.Cars.FindAsync(id);
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
            var value = await _context.Cars.FindAsync(id);
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

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public List<Car> GetCarsListWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).Include(x => x.Category).ToList();
            return values;
        }
        public List<Car> GetLast5CarsWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).Include(x => x.Category).Where(x => x.IsActive && x.IsShown).OrderByDescending(x => x.CarID).Take(5).ToList();
            return values;
        }
    }
}