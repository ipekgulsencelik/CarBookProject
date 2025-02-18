using AutoMapper;
using CarBook.Application.Features.Mediator.Commands.FeatureCommands;
using CarBook.Application.Features.Mediator.Results.FeatureResults;
using CarBook.Domain.Entities;

namespace CarBook.API.Mappings
{
    public class FeatureMapping : Profile
    {
        public FeatureMapping()
        {
            CreateMap<GetFeatureQueryResult, Feature>().ReverseMap();
            CreateMap<GetFeatureByIdQueryResult, Feature>().ReverseMap();
            CreateMap<UpdateFeatureCommand, Feature>().ReverseMap();
        }
    }
}