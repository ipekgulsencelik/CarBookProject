using AutoMapper;
using CarBook.Application.Features.CQRS.Commands.MessageCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.MessageHandlers
{
    public class CreateMessageCommandHandler
    {
        private readonly IRepository<Message> _repository;
        private readonly IMapper _mapper;

        public CreateMessageCommandHandler(IRepository<Message> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateMessageCommand command)
        {
            command.IsRead = false;
            var about = _mapper.Map<Message>(command);
            await _repository.CreateAsync(about);
        }
    }
}