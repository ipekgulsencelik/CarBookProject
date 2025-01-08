using AutoMapper;
using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly IRepository<About> _repository;
        private readonly IMapper _mapper;

        public GetAboutQueryHandler(IRepository<About> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetAboutQueryResult>> Handle()
        {
            var values = await _repository.GetListAsync();
            return _mapper.Map<List<GetAboutQueryResult>>(values);
        }
    }
}