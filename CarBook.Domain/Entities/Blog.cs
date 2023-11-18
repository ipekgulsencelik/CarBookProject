namespace CarBook.Domain.Entities
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Title { get; set; }        
        public string CoverImageURL { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsHome { get; set; }
        public bool Status { get; set; }

        public int AuthorID { get; set; }
        public Author Author { get; set; }
        
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}