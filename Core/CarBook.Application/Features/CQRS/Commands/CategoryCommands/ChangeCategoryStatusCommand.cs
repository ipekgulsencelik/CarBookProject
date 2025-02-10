namespace CarBook.Application.Features.CQRS.Commands.CategoryCommands
{
    public class ChangeCategoryStatusCommand
    {
        public int CategoryID { get; set; }

        public ChangeCategoryStatusCommand(int categoryID)
        {
            CategoryID = categoryID;
        }
    }
}