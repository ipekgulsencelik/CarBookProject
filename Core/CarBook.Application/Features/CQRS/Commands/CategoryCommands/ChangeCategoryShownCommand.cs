namespace CarBook.Application.Features.CQRS.Commands.CategoryCommands
{
    public class ChangeCategoryShownCommand
    {
        public int CategoryID { get; set; }

        public ChangeCategoryShownCommand(int categoryID)
        {
            CategoryID = categoryID;
        }
    }
}