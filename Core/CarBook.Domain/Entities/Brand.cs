namespace CarBook.Domain.Entities
{
    public class Brand
    {
        public int BrandID { get; set; }
        public string? BrandName { get; set; }
        public bool IsActive { get; set; }
        public bool IsShown { get; set; }

        public List<Car> Cars { get; set; }
    }
}