using CarBook.Application.Features.CQRS.Commands.CategoryCommands;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class ChangeCategoryShownCommandHandler
    {
        private readonly ICategoryRepository _repository;

        public ChangeCategoryShownCommandHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(ChangeCategoryShownCommand command)
        {
            await _repository.ChangeShownStatus(command.CategoryID);
        }
    }
}