using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class ChangeCarStatusCommandHandler
    {
        private readonly ICarRepository _repository;

        public ChangeCarStatusCommandHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(ChangeCarStatusCommand command)
        {
            await _repository.ChangeStatus(command.CarID);
        }
    }
}