using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces
{
    public interface IMessageRepository : IRepository<Message>
    {
        Task ChangeStatus(int id);
    }
}