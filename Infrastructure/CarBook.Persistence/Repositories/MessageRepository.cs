using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;

namespace CarBook.Persistence.Repositories
{
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        public MessageRepository(CarBookContext context) : base(context)
        {
        }

        public async Task ChangeStatus(int id)
        {
            var value = await _context.Messages.FindAsync(id);
            if (value.IsRead == true)
            {
                value.IsRead = false;
            }
            else
            {
                value.IsRead = true;
            }
            _context.Update(value);
            _context.SaveChangesAsync();
        }
    }
}