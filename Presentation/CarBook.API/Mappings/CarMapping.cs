using AutoMapper;
using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Domain.Entities;

namespace CarBook.API.Mappings
{
    public class CarMapping : Profile
    {
        public CarMapping()
        {
            CreateMap<GetCarQueryResult, Car>().ReverseMap();
            CreateMap<GetCarByIdQueryResult, Car>().ReverseMap();
            CreateMap<CreateCarCommand, Car>().ReverseMap();
            CreateMap<UpdateCarCommand, Car>().ReverseMap();
        }
    }
}