namespace CarBook.Application.Features.CQRS.Commands.CarCommands
{
    public class ChangeCarShownCommand
    {
        public int CarID { get; set; }

        public ChangeCarShownCommand(int carID)
        {
            CarID = carID;
        }
    }
}