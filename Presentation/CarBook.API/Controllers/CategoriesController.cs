using CarBook.Application.Features.CQRS.Commands.CategoryCommands;
using CarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
using CarBook.Application.Features.CQRS.Queries.CategoryQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CreateCategoryCommandHandler _createCategoryCommandHandler;
        private readonly GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler;
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
        private readonly UpdateCategoryCommandHandler _updateCategoryCommandHandler;
        private readonly RemoveCategoryCommandHandler _removeCategoryCommandHandler;
        private readonly ChangeCategoryShownCommandHandler _changeCategoryShownCommandHandler;
        private readonly ChangeCategoryStatusCommandHandler _changeCategoryStatusCommandHandler;

        public CategoriesController(CreateCategoryCommandHandler createCategoryCommandHandler, GetCategoryByIdQueryHandler getCategoryByIdQueryHandler, GetCategoryQueryHandler getCategoryQueryHandler, UpdateCategoryCommandHandler updateCategoryCommandHandler, RemoveCategoryCommandHandler removeCategoryCommandHandler, ChangeCategoryShownCommandHandler changeCategoryShownCommandHandler, ChangeCategoryStatusCommandHandler changeCategoryStatusCommandHandler)
        {
            _createCategoryCommandHandler = createCategoryCommandHandler;
            _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
            _getCategoryQueryHandler = getCategoryQueryHandler;
            _updateCategoryCommandHandler = updateCategoryCommandHandler;
            _removeCategoryCommandHandler = removeCategoryCommandHandler;
            _changeCategoryShownCommandHandler = changeCategoryShownCommandHandler;
            _changeCategoryStatusCommandHandler = changeCategoryStatusCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoryList()
        {
            var values = await _getCategoryQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var value = await _getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
        {
            await _createCategoryCommandHandler.Handle(command);
            return Ok("Kategori Bilgisi Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCategory(int id)
        {
            await _removeCategoryCommandHandler.Handle(new RemoveCategoryCommand(id));
            return Ok("Kategori Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            await _updateCategoryCommandHandler.Handle(command);
            return Ok("Kategori Bilgisi Güncellendi");
        }


        [HttpPut("ChangeCategoryStatus/{id}")]
        public async Task<IActionResult> ChangeCategoryStatus(int id)
        {
            await _changeCategoryStatusCommandHandler.Handle(new ChangeCategoryStatusCommand(id));
            return Ok("Durum Değiştirildi");
        }

        [HttpPut("ChangeCategoryShown/{id}")]
        public async Task<IActionResult> ChangeCategoryShown(int id)
        {
            await _changeCategoryShownCommandHandler.Handle(new ChangeCategoryShownCommand(id));
            return Ok("Ana Sayfa Görünürlük Durumu Değiştirildi");
        }
    }
}