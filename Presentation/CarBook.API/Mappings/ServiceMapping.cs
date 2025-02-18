using AutoMapper;
using CarBook.Application.Features.Mediator.Commands.ServiceCommands;
using CarBook.Application.Features.Mediator.Results.ServiceResults;
using CarBook.Domain.Entities;

namespace CarBook.API.Mappings
{
    public class ServiceMapping : Profile
    {
        public ServiceMapping()
        {
            CreateMap<GetServiceQueryResult, Service>().ReverseMap();
            CreateMap<GetServiceByIdQueryResult, Service>().ReverseMap();
            CreateMap<CreateServiceCommand, Service>().ReverseMap();
            CreateMap<UpdateServiceCommand, Service>().ReverseMap();
        }
    }
}