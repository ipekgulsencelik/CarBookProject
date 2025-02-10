using AutoMapper;
using CarBook.Application.Features.CQRS.Results.MessageResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.MessageHandlers
{
    public class GetMessageQueryHandler
    {
        private readonly IRepository<Message> _repository;
        private readonly IMapper _mapper;

        public GetMessageQueryHandler(IRepository<Message> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetMessageQueryResult>> Handle()
        {
            var values = await _repository.GetListAsync();
            return _mapper.Map<List<GetMessageQueryResult>>(values);
        }
    }
}