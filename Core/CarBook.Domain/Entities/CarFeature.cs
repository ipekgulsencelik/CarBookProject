namespace CarBook.Domain.Entities
{
    public class CarFeature
    {
        public int CarFeatureID { get; set; }
        public bool IsActive { get; set; }
        public bool IsShown { get; set; }
        public bool HasFeature { get; set; }

        public int CarID { get; set; }
        public Car Car { get; set; }

        public int FeatureID { get; set; }
        public Feature Feature { get; set; }
    }
}