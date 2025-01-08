namespace CarBook.Application.Features.CQRS.Commands.BannerCommands
{
    public class UpdateBannerShownAsTrueCommand
    {
        public int BannerID { get; set; }

        public UpdateBannerShownAsTrueCommand(int bannerID)
        {
            BannerID = bannerID;
        }
    }
}