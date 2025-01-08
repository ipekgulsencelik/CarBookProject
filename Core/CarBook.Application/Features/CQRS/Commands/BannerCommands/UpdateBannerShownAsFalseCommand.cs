namespace CarBook.Application.Features.CQRS.Commands.BannerCommands
{
    public class UpdateBannerShownAsFalseCommand
    {
        public int BannerID { get; set; }

        public UpdateBannerShownAsFalseCommand(int bannerID)
        {
            BannerID = bannerID;
        }
    }
}