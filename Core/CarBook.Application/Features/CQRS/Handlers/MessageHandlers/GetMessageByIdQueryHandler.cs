using AutoMapper;
using CarBook.Application.Features.CQRS.Queries.MessageQueries;
using CarBook.Application.Features.CQRS.Results.MessageResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.MessageHandlers
{
    public class GetMessageByIdQueryHandler
    {
        private readonly IRepository<Message> _repository;
        private readonly IMapper _mapper;

        public GetMessageByIdQueryHandler(IRepository<Message> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetMessageByIdQueryResult> Handle(GetMessageByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return _mapper.Map<GetMessageByIdQueryResult>(values);
        }
    }
}