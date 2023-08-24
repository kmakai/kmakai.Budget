using System.ComponentModel.DataAnnotations;

namespace kmakai.Budget.Models;

public class Transaction
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Amount { get; set; }

    public int TransactionTypeId { get; set; }

    public TransactionType TransactionType { get; set; } = null!;

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true )]
    public DateTime Date { get; set; }

    public int CategoryId { get; set; }

    public Category Category { get; set; } = null!;

}
