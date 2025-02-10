namespace CarBook.Application.Features.CQRS.Results.MessageResults
{
    public class GetMessageQueryResult
    {
        public int MessageID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Content { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}