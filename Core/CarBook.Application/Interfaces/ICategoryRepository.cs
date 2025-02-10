using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task ChangeStatus(int id);
        Task ChangeShownStatus(int id);
    }
}