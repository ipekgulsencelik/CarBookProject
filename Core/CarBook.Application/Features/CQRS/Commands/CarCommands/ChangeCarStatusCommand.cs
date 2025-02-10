namespace CarBook.Application.Features.CQRS.Commands.CarCommands
{
    public class ChangeCarStatusCommand
    {
        public int CarID { get; set; }

        public ChangeCarStatusCommand(int carID)
        {
            CarID = carID;
        }
    }
}