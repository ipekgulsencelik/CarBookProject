using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class ChangeCarShownCommandHandler
    {
        private readonly ICarRepository _repository;

        public ChangeCarShownCommandHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(ChangeCarShownCommand command)
        {
            await _repository.ChangeShownStatus(command.CarID);
        }
    }
}