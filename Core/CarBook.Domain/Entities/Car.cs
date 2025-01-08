using System.Text.Json.Serialization;

namespace CarBook.Domain.Entities
{
    public class Car
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }
        [JsonIgnore]
        public Brand Brand { get; set; }
        public string? CarName { get; set; }
        public int Year { get; set; }
        public int CategoryID { get; set; }
        [JsonIgnore]
        public Category Category { get; set; }
        public string? CoverImageUrl { get; set; }
        public string? ImageUrl { get; set; }
        public int Km { get; set; }
        public string? Gear { get; set; }
        public byte PersonCount { get; set; }
        public byte Luggage { get; set; }
        public string? GasType { get; set; }
        public decimal RentPrice { get; set; }
        public bool IsActive { get; set; }
        public bool IsShown { get; set; }

        public List<CarFeature> CarFeatures { get; set; }
        public List<CarDescription> CarDescriptions { get; set; }
        public List<CarPrice> CarPrices { get; set; }
    }
}