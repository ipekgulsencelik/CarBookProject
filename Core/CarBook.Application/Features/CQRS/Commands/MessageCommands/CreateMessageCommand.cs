namespace CarBook.Application.Features.CQRS.Commands.MessageCommands
{
    public class CreateMessageCommand
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Content { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}