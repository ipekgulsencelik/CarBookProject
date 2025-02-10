namespace CarBook.Application.Features.CQRS.Commands.CategoryCommands
{
    public class UpdateCategoryCommand
    {
        public int CategoryID { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsShown { get; set; }
    }
}