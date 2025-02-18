using AutoMapper;
using CarBook.Application.Features.Mediator.Commands.SocialMediaCommands;
using CarBook.Application.Features.Mediator.Results.SocialMediaResults;
using CarBook.Domain.Entities;

namespace CarBook.API.Mappings
{
    public class SocialMediaMapping : Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<GetSocialMediaQueryResult, SocialMedia>().ReverseMap();
            CreateMap<GetSocialMediaByIdQueryResult, SocialMedia>().ReverseMap();
            CreateMap<CreateSocialMediaCommand, SocialMedia>().ReverseMap();
            CreateMap<UpdateSocialMediaCommand, SocialMedia>().ReverseMap();
        }
    }
}