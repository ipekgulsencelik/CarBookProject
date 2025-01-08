using AutoMapper;
using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Features.CQRS.Results.BannerResults;
using CarBook.Domain.Entities;

namespace CarBook.API.Mappings
{
    public class BannerMapping : Profile
    {
        public BannerMapping()
        {
            CreateMap<GetBannerQueryResult, Banner>().ReverseMap();
            CreateMap<GetBannerByIdQueryResult, Banner>().ReverseMap();
            CreateMap<CreateBannerCommand, Banner>().ReverseMap();
            CreateMap<UpdateBannerCommand, Banner>().ReverseMap();
        }
    }
}