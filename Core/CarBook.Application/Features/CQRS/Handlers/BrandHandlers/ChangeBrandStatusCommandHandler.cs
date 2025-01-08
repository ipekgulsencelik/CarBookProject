using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class ChangeBrandStatusCommandHandler
    {
        private readonly IBrandRepository _repository;

        public ChangeBrandStatusCommandHandler(IBrandRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(ChangeBrandStatusCommand command)
        {
            await _repository.ChangeStatus(command.BrandID);
        }
    }
}