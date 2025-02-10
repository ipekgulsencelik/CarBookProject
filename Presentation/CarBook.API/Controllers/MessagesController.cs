using CarBook.Application.Features.CQRS.Commands.MessageCommands;
using CarBook.Application.Features.CQRS.Handlers.MessageHandlers;
using CarBook.Application.Features.CQRS.Queries.MessageQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly CreateMessageCommandHandler _createMessageCommandHandler;
        private readonly GetMessageByIdQueryHandler _getMessageByIdQueryHandler;
        private readonly GetMessageQueryHandler _getMessageQueryHandler;
        private readonly UpdateMessageCommandHandler _updateMessageCommandHandler;
        private readonly RemoveMessageCommandHandler _removeMessageCommandHandler;
        private readonly ChangeMessageStatusCommandHandler _changeMessageStatusCommandHandler;

        public MessagesController(CreateMessageCommandHandler createMessageCommandHandler, GetMessageByIdQueryHandler getMessageByIdQueryHandler, GetMessageQueryHandler getMessageQueryHandler, UpdateMessageCommandHandler updateMessageCommandHandler, RemoveMessageCommandHandler removeMessageCommandHandler,  ChangeMessageStatusCommandHandler changeMessageStatusCommandHandler)
        {
            _createMessageCommandHandler = createMessageCommandHandler;
            _getMessageByIdQueryHandler = getMessageByIdQueryHandler;
            _getMessageQueryHandler = getMessageQueryHandler;
            _updateMessageCommandHandler = updateMessageCommandHandler;
            _removeMessageCommandHandler = removeMessageCommandHandler;
            _changeMessageStatusCommandHandler = changeMessageStatusCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetMessageList()
        {
            var values = await _getMessageQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMessage(int id)
        {
            var value = await _getMessageByIdQueryHandler.Handle(new GetMessageByIdQuery(id));
            return Ok(value);
        }

        [HttpPut("ChangeMessageStatus/{id}")]
        public async Task<IActionResult> ChangeMessageStatus(int id)
        {
            await _changeMessageStatusCommandHandler.Handle(new ChangeMessageStatusCommand(id));
            return Ok("Durum Değiştirildi");
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageCommand command)
        {
            await _createMessageCommandHandler.Handle(command);
            return Ok("Mesaj Bilgisi Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveMessage(int id)
        {
            await _removeMessageCommandHandler.Handle(new RemoveMessageCommand(id));
            return Ok("Mesaj Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMessage(UpdateMessageCommand command)
        {
            await _updateMessageCommandHandler.Handle(command);
            return Ok("Mesaj Bilgisi Güncellendi");
        }
    }
}