namespace CarBook.Application.Features.CQRS.Commands.BrandCommands
{
    public class ChangeBrandStatusCommand
    {
        public int BrandID { get; set; }

        public ChangeBrandStatusCommand(int brandID)
        {
            BrandID = brandID;
        }
    }
}