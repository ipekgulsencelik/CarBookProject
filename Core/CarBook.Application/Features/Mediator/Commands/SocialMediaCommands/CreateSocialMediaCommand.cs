using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.SocialMediaCommands
{
    public class CreateSocialMediaCommand : IRequest
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? Icon { get; set; }
        public bool IsActive { get; set; }
        public bool IsShown { get; set; }
    }
}