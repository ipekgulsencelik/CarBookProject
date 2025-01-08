using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces
{
    public interface IBrandRepository : IRepository<Brand>
    {
        Task ChangeStatus(int id);
        Task ChangeShownStatus(int id);
    }
}