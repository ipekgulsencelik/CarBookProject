namespace CarBook.Application.Features.Mediator.Results.ContactResults
{
    public class GetContactByIdQueryResult
    {
        public int ContactID { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}