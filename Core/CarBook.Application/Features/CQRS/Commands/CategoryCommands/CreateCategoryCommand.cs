namespace CarBook.Application.Features.CQRS.Commands.CategoryCommands
{
    public class CreateCategoryCommand
    {
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsShown { get; set; }
    }
}