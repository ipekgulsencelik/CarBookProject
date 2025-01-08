namespace CarBook.Application.Features.CQRS.Commands.BrandCommands
{
    public class CreateBrandCommand
    {
        public string? BrandName { get; set; }
        public bool IsActive { get; set; }
        public bool IsShown { get; set; }
    }
}