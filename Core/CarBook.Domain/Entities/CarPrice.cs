namespace CarBook.Domain.Entities
{
    public class CarPrice
    {
        public int CarPriceID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int PriceID { get; set; }
        public Price Price { get; set; }
        public decimal PriceValue { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsShown { get; set; }
    }
}