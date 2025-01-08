namespace CarBook.Application.Features.CQRS.Commands.BrandCommands
{
    public class UpdateBrandCommand
    {
        public int BrandID { get; set; }
        public string? BrandName { get; set; }
        public bool IsActive { get; set; }
        public bool IsShown { get; set; }
    }
}