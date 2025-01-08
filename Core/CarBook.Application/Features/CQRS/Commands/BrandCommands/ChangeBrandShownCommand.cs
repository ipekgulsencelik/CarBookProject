namespace CarBook.Application.Features.CQRS.Commands.BrandCommands
{
    public class ChangeBrandShownCommand
    {
        public int BrandID { get; set; }

        public ChangeBrandShownCommand(int bannerID)
        {
            BrandID = bannerID;
        }
    }
}