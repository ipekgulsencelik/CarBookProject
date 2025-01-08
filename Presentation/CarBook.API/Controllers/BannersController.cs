using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Features.CQRS.Handlers.BannerHandlers;
using CarBook.Application.Features.CQRS.Queries.BannerQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
        private readonly GetBannerQueryHandler _getBannerQueryHandler;
        private readonly GetBannerByIdQueryHandler _getBannerByIdQueryHandler;
        private readonly CreateBannerCommandHandler _createBannerCommandHandler;
        private readonly UpdateBannerCommandHandler _updateBannerCommandHandler;
        private readonly RemoveBannerCommandHandler _removeBannerCommandHandler;
        private readonly ChangeBannerStatusCommandHandler _changeBannerStatusCommandHandler;
        private readonly UpdateBannerShownAsFalseCommandHandler _updateBannerShownAsFalseCommandHandler;
        private readonly UpdateBannerShownAsTrueCommandHandler _updateBannerShownAsTrueCommandHandler;

        public BannersController(GetBannerQueryHandler getBannerQueryHandler, GetBannerByIdQueryHandler getBannerByIdQueryHandler, CreateBannerCommandHandler createBannerCommandHandler, UpdateBannerCommandHandler updateBannerCommandHandler, RemoveBannerCommandHandler removeBannerCommandHandler, ChangeBannerStatusCommandHandler changeBannerStatusCommandHandler, UpdateBannerShownAsFalseCommandHandler updateBannerShownAsFalseCommandHandler, UpdateBannerShownAsTrueCommandHandler updateBannerShownAsTrueCommandHandler)
        {
            _getBannerQueryHandler = getBannerQueryHandler;
            _getBannerByIdQueryHandler = getBannerByIdQueryHandler;
            _createBannerCommandHandler = createBannerCommandHandler;
            _updateBannerCommandHandler = updateBannerCommandHandler;
            _removeBannerCommandHandler = removeBannerCommandHandler;
            _changeBannerStatusCommandHandler = changeBannerStatusCommandHandler;
            _updateBannerShownAsFalseCommandHandler = updateBannerShownAsFalseCommandHandler;
            _updateBannerShownAsTrueCommandHandler = updateBannerShownAsTrueCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetBannerList()
        {
            var values = await _getBannerQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBanner(int id)
        {
            var value = await _getBannerByIdQueryHandler.Handle(new GetBannerByIdQuery(id));
            return Ok(value);
        }

        [HttpPut("ChangeBannerStatus/{id}")]
        public async Task<IActionResult> ChangeBannerStatus(int id)
        {
            await _changeBannerStatusCommandHandler.Handle(new ChangeBannerStatusCommand(id));
            return Ok("Durum Değiştirildi");
        }

        [HttpPut("ShowOnHome/{id}")]
        public async Task<IActionResult> ShowOnHome(int id)
        {
            await _updateBannerShownAsTrueCommandHandler.Handle(new UpdateBannerShownAsTrueCommand(id));
            return Ok("Ana Sayfada Gösteriliyor");
        }

        [HttpPut("DontShowOnHome/{id}")]
        public async Task<IActionResult> DontShowOnHome(int id)
        {
            await _updateBannerShownAsFalseCommandHandler.Handle(new UpdateBannerShownAsFalseCommand(id));
            return Ok("Ana Sayfada Gösterilmiyor");
        }

        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerCommand command)
        {
            await _createBannerCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBanner(int id)
        {
            await _removeBannerCommandHandler.Handle(new RemoveBannerCommand(id));
            return Ok("Bilgi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBanner(UpdateBannerCommand command)
        {
            await _updateBannerCommandHandler.Handle(command);
            return Ok("Bilgi Güncellendi");
        }
    }
}