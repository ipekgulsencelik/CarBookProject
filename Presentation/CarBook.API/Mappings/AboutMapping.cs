using AutoMapper;
using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Domain.Entities;

namespace CarBook.API.Mappings
{
    public class AboutMapping : Profile
    {
        public AboutMapping() 
        {
            CreateMap<GetAboutQueryResult, About>().ReverseMap();
            CreateMap<GetAboutByIdQueryResult, About>().ReverseMap();
            CreateMap<CreateAboutCommand, About>().ReverseMap();
            CreateMap<UpdateAboutCommand, About>().ReverseMap();
        }
    }
}