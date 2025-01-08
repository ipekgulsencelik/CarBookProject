namespace CarBook.Application.Features.CQRS.Commands.BannerCommands
{
    public class ChangeBannerStatusCommand
    {
        public int BannerID { get; set; }

        public ChangeBannerStatusCommand(int bannerID)
        {
            BannerID = bannerID;
        }
    }
}