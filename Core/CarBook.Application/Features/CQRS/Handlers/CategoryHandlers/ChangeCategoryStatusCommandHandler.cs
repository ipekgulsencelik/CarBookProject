using CarBook.Application.Features.CQRS.Commands.CategoryCommands;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class ChangeCategoryStatusCommandHandler
    {
        private readonly ICategoryRepository _repository;

        public ChangeCategoryStatusCommandHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(ChangeCategoryStatusCommand command)
        {
            await _repository.ChangeStatus(command.CategoryID);
        }
    }
}