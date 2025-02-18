using AutoMapper;
using CarBook.Application.Features.Mediator.Commands.ContactCommands;
using CarBook.Application.Features.Mediator.Results.ContactResults;
using CarBook.Domain.Entities;

namespace ContactBook.API.Mappings
{
    public class ContactMapping : Profile
    {
        public ContactMapping()
        {
            CreateMap<GetContactQueryResult, Contact>().ReverseMap();
            CreateMap<GetContactByIdQueryResult, Contact>().ReverseMap();
            CreateMap<UpdateContactCommand, Contact>().ReverseMap();
        }
    }
}