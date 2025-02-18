using AutoMapper;
using CarBook.Application.Features.Mediator.Commands.PricingCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class CreatePricingCommandHandler : IRequestHandler<CreatePricingCommand>
    {
        private readonly IRepository<Price> _repository;
        private readonly IMapper _mapper;

        public CreatePricingCommandHandler(IRepository<Price> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreatePricingCommand request, CancellationToken cancellationToken)
        {
            var pricing = _mapper.Map<Price>(request);
            await _repository.CreateAsync(pricing);
        }
    }
}