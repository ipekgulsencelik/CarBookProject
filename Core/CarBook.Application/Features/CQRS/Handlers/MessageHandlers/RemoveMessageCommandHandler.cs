using CarBook.Application.Features.CQRS.Commands.MessageCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.MessageHandlers
{
    public class RemoveMessageCommandHandler
    {
        private readonly IRepository<Message> _repository;

        public RemoveMessageCommandHandler(IRepository<Message> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveMessageCommand command)
        {
            await _repository.DeleteAsync(command.Id);
        }
    }
}