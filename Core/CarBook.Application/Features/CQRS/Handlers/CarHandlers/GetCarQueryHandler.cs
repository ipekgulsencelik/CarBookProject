using AutoMapper;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;
        private readonly IMapper _mapper;

        public GetCarQueryHandler(IRepository<Car> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repository.GetListAsync();
            return _mapper.Map<List<GetCarQueryResult>>(values);
        }
    }
}