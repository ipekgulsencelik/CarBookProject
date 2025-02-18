using AutoMapper;
using CarBook.Application.Features.Mediator.Commands.PricingCommands;
using CarBook.Application.Features.Mediator.Results.PricingResults;
using CarBook.Domain.Entities;

namespace CarBook.API.Mappings
{
    public class PricingMapping : Profile
    {
        public PricingMapping()
        {
            CreateMap<GetPricingQueryResult, Price>().ReverseMap();
            CreateMap<GetPricingByIdQueryResult, Price>().ReverseMap();
            CreateMap<CreatePricingCommand, Price>().ReverseMap();
            CreateMap<UpdatePricingCommand, Price>().ReverseMap();
        }
    }
}