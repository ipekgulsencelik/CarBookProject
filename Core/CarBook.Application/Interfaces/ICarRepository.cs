using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces
{
    public interface ICarRepository : IRepository<Car>
    {
        Task ChangeStatus(int id);
        Task ChangeShownStatus(int id);
        List<Car> GetCarsListWithBrands();
        List<Car> GetLast5CarsWithBrands();
        int GetCarCount();
    }
}