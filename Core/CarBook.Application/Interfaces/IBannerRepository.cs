using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces
{
    public interface IBannerRepository : IRepository<Banner>
    {
        Task ChangeStatusAsync(int id);
        Task ShowOnHome(int id);
        Task DontShowOnHome(int id);
    }
}