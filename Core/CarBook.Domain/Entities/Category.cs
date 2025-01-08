namespace CarBook.Domain.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsShown { get; set; }

        public List<Car> Cars { get; set; }
    }
}