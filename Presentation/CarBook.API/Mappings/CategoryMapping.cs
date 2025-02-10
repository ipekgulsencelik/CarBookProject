using AutoMapper;
using CarBook.Application.Features.CQRS.Commands.CategoryCommands;
using CarBook.Application.Features.CQRS.Results.CategoryResults;
using CarBook.Domain.Entities;

namespace CarBook.API.Mappings
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<GetCategoryQueryResult, Category>().ReverseMap();
            CreateMap<GetCategoryByIdQueryResult, Category>().ReverseMap();
            CreateMap<CreateCategoryCommand, Category>().ReverseMap();
            CreateMap<UpdateCategoryCommand, Category>().ReverseMap();
        }
    }
}