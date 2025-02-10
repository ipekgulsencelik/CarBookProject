namespace CarBook.Application.Features.CQRS.Queries.MessageQueries
{
    public class GetMessageByIdQuery
    {
        public int Id { get; set; }

        public GetMessageByIdQuery(int id)
        {
            Id = id;
        }
    }
}