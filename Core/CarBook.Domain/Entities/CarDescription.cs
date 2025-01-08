namespace CarBook.Domain.Entities
{
    public class CarDescription
    {
        public int CarDescriptionID { get; set; }
        public string? Description { get; set; }
        public bool IsActiive { get; set; }

        public int CarID { get; set; }
        public Car Car { get; set; }
    }
}