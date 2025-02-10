using CarBook.Application.Features.CQRS.Commands.MessageCommands;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.MessageHandlers
{
    public class ChangeMessageStatusCommandHandler
    {
        private readonly IMessageRepository _repository;

        public ChangeMessageStatusCommandHandler(IMessageRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(ChangeMessageStatusCommand command)
        {
            await _repository.ChangeStatus(command.MessageID);
        }
    }
}