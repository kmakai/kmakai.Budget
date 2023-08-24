namespace kmakai.Budget.Models.ViewModels;

public class HomeViewModel
{
    public IEnumerable<Transaction> Transactions { get; set; } = new List<Transaction>();
    public IEnumerable<Category> Categories { get; set; } = new List<Category>();
    public IEnumerable<TransactionType> TransactionTypes { get; set; } = new List<TransactionType>();

    public AddCategoryViewModel AddCategory { get; set; } = new AddCategoryViewModel();

}
