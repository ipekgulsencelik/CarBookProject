namespace CarBook.Application.Features.CQRS.Commands.MessageCommands
{
    public class ChangeMessageStatusCommand
    {
        public int MessageID { get; set; }

        public ChangeMessageStatusCommand(int messageID)
        {
            MessageID = messageID;
        }
    }
}