using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.PricingCommands
{
    public class CreatePricingCommand : IRequest
    {
        public string? PriceType { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsShown { get; set; }
    }
}