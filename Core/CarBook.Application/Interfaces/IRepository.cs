namespace CarBook.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetListAsync();
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<bool> SaveChangesAsync();
    }
}