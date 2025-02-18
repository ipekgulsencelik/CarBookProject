using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.ContactCommands
{
    public class UpdateContactCommand : IRequest
    {
        public int ContactID { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}