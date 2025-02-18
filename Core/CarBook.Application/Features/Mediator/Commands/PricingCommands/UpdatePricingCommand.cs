using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.PricingCommands
{
    public class UpdatePricingCommand : IRequest
    {
        public int PriceID { get; set; }
        public string? PriceType { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsShown { get; set; }
    }
}