using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerShownAsFalseCommandHandler
    {
        private readonly IBannerRepository _repository;

        public UpdateBannerShownAsFalseCommandHandler(IBannerRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerShownAsFalseCommand command)
        {
            await _repository.DontShowOnHome(command.BannerID);
        }
    }
}