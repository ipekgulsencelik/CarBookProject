namespace CarBook.Application.Features.Mediator.Results.PricingResults
{
    public class GetPricingQueryResult
    {
        public int PriceID { get; set; }
        public string? PriceType { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsShown { get; set; }
    }
}