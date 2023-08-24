using kmakai.Budget.Context;
using kmakai.Budget.Models;
using kmakai.Budget.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace kmakai.Budget.Controllers
{
    public class HomeController : Controller
    {
        private readonly CategoryController _categoryController;
        private readonly TransactionController _transactionController;

        public HomeController(CategoryController categoryController, TransactionController transactionController)
        {
            _categoryController = categoryController;
            _transactionController = transactionController;
        }

        public IActionResult Index()
        {

            var viewModel = new HomeViewModel
            {
                Categories = _categoryController.GetCategories(),
                Transactions = _transactionController.GetTransactions(),
                TransactionTypes = _transactionController.GetTransactionTypes()

            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddCategory(AddCategoryViewModel addCategory)
        {
            var category = new Category
            {
                Name = addCategory.Name
            };

            if (addCategory.Id != 0)
            {
                category.Id = addCategory.Id;
                _categoryController.UpdateCategory(category);
            }
            else
            {
                _categoryController.AddCategory(category);
            }

            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id)
        {
            _categoryController.DeleteCategory(id);
            return RedirectToAction("Index");
        }



    }
}