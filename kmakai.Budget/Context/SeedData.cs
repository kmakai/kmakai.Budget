using kmakai.Budget.Models;
using Microsoft.EntityFrameworkCore;

namespace kmakai.Budget.Context;

public class SeedData
{

    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new BudgetContext(serviceProvider.GetRequiredService<DbContextOptions<BudgetContext>>());

        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        SeedCategories(context);
        SeedExpenseTransactions(context);
        SeedIncomeTransactions(context);
    }

    public static void SeedCategories(BudgetContext context)
    {
        context.Categories.AddRange(
            new Category
            {
                Name = "Food"
            },
            new Category
            {
                Name = "Rent"
            },
            new Category
            {
                Name = "Utilities"
            },
            new Category
            {
                Name = "Entertainment"
            },
            new Category
            {
                Name = "Transportation"
            }, new Category
            {
                Name = "Other"
            },
            new Category
            {
                Name = "Income"
            });

        context.SaveChanges();
    }

    public static void SeedExpenseTransactions(BudgetContext context)
    {
        context.Transactions.AddRange(
            new Transaction
            {
                Name = "Groceries",
                Amount = 100,
                TransactionTypeId = 2,
                Date = DateTime.Now,
                CategoryId = 1
            },
            new Transaction
            {
                Name = "Rent",
                Amount = 1000,
                TransactionTypeId = 2,
                Date = DateTime.Now,
                CategoryId = 2
            },
            new Transaction
            {
                Name = "Electricity",
                Amount = 100,
                TransactionTypeId = 2,
                Date = DateTime.Now,
                CategoryId = 3
            },
            new Transaction
            {
                Name = "Internet",
                Amount = 100,
                TransactionTypeId = 2,
                Date = DateTime.Now,
                CategoryId = 3
            },
            new Transaction
            {
                Name = "Netflix",
                Amount = 10,
                TransactionTypeId = 2,
                Date = DateTime.Now,
                CategoryId = 4
            },
            new Transaction
            {
                Name = "Spotify",
                Amount = 10,
                TransactionTypeId = 2,
                Date = DateTime.Now,
                CategoryId = 4
            },
            new Transaction
            {
                Name = "Gas",
                Amount = 50,
                TransactionTypeId = 2,
                Date = DateTime.Now,
                CategoryId = 5
            },
            new Transaction
            {
                Name = "Car Insurance",
                Amount = 100,
                TransactionTypeId = 2,
                Date = DateTime.Now,
                CategoryId = 5
            },
            new Transaction
            {
                Name = "Car Payment",
                Amount = 200,
                TransactionTypeId = 2,
                Date = DateTime.Now,
                CategoryId = 5
            }
            );

        context.SaveChanges();
    }

    public static void SeedIncomeTransactions(BudgetContext context)
    {
        context.Transactions.AddRange(
            new Transaction
            {
                Name = "Paycheck",
                Amount = 1000,
                TransactionTypeId = 1,
                Date = DateTime.Now,
                CategoryId = 7
            },
            new Transaction
            {
                Name = "Paycheck",
                Amount = 1000,
                TransactionTypeId = 1,
                Date = DateTime.Now,
                CategoryId = 7
            },
            new Transaction
            {
                Name = "Paycheck",
                Amount = 1000,
                TransactionTypeId = 1,
                Date = DateTime.Now,
                CategoryId = 7
            },
            new Transaction
            {
                Name = "Paycheck",
                Amount = 1000,
                TransactionTypeId = 1,
                Date = DateTime.Now,
                CategoryId = 7
            },
            new Transaction
            {
                Name = "Paycheck",
                Amount = 1000,
                TransactionTypeId = 1,
                Date = DateTime.Now,
                CategoryId = 7
            }
            );

        context.SaveChanges();
    }
}
