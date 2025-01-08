using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class ChangeBannerStatusCommandHandler
    {
        private readonly IBannerRepository _repository;

        public ChangeBannerStatusCommandHandler(IBannerRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(ChangeBannerStatusCommand command)
        {
            await _repository.ChangeStatusAsync(command.BannerID);
        }
    }
}