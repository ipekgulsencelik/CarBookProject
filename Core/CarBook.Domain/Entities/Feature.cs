namespace CarBook.Domain.Entities
{
    public class Feature
    {
        public int FeatureID { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; } = true;

        public List<CarFeature> CarFeatures { get; set; }
    }
}