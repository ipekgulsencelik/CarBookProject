using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerShownAsTrueCommandHandler
    {
        private readonly IBannerRepository _repository;

        public UpdateBannerShownAsTrueCommandHandler(IBannerRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerShownAsTrueCommand command)
        {
            await _repository.ShowOnHome(command.BannerID);
        }
    }
}