using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class ChangeBrandShownCommandHandler
    {
        private readonly IBrandRepository _repository;

        public ChangeBrandShownCommandHandler(IBrandRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(ChangeBrandShownCommand command)
        {
            await _repository.ChangeShownStatus(command.BrandID);
        }
    }
}