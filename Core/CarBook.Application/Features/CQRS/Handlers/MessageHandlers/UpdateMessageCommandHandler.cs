using AutoMapper;
using CarBook.Application.Features.CQRS.Commands.MessageCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.MessageHandlers
{
    public class UpdateMessageCommandHandler
    {
        private readonly IRepository<Message> _repository;
        private readonly IMapper _mapper;

        public UpdateMessageCommandHandler(IRepository<Message> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateMessageCommand command)
        {
            var about = _mapper.Map<Message>(command);
            await _repository.UpdateAsync(about);
        }
    }
}