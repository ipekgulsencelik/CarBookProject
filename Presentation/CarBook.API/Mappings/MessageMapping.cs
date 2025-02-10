using AutoMapper;
using CarBook.Application.Features.CQRS.Commands.MessageCommands;
using CarBook.Application.Features.CQRS.Results.MessageResults;
using CarBook.Domain.Entities;

namespace CarBook.API.Mappings
{
    public class MessageMapping : Profile
    {
        public MessageMapping()
        {
            CreateMap<GetMessageQueryResult, Message>().ReverseMap();
            CreateMap<GetMessageByIdQueryResult, Message>().ReverseMap();
            CreateMap<CreateMessageCommand, Message>().ReverseMap();
            CreateMap<UpdateMessageCommand, Message>().ReverseMap();
        }
    }
}