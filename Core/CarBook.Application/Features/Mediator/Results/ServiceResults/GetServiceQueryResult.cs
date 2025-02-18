namespace CarBook.Application.Features.Mediator.Results.ServiceResults
{
    public class GetServiceQueryResult
    {
        public int ServiceID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
        public bool IsActive { get; set; }
        public bool IsShown { get; set; }
    }
}