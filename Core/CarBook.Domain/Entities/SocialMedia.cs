namespace CarBook.Domain.Entities
{
    public class SocialMedia
    {
        public int SocialMediaID { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? Icon { get; set; }
        public bool IsActive { get; set; }
        public bool IsShown { get; set; }
    }
}