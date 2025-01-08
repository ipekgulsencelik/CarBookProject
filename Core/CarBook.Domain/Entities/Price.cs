namespace CarBook.Domain.Entities
{
    public class Price
    {
        public int PriceID { get; set; }
        public string? PriceType { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsShown { get; set; }
        public List<CarPrice> CarPrices { get; set; }
    }
}