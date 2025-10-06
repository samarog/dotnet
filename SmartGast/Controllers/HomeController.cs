using Microsoft.AspNetCore.Mvc;
using SmartGast.Data;
using SmartGast.Models;
using System.Diagnostics;

namespace SmartGast.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly SmartGastDbContext _context;

        public HomeController(ILogger<HomeController> logger, SmartGastDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Expenses()
        {
            var allExpenses = _context.ExpensesTable.ToList();

            var totalExpenses = allExpenses.Sum(expense => expense.Value);
            ViewBag.TotalExpenses = totalExpenses;

            return View(allExpenses);
        }
        public IActionResult CreateOrEditAnExpense(int? id)
        {
            var expenseToEdit = _context.ExpensesTable.SingleOrDefault(expense => expense.Id == id);
            if (expenseToEdit != null)
            {
                return View(expenseToEdit);
            }
            return View();
        }
        public IActionResult ExpenseSubmitted(Expense model)
        {

            if (model.Id == 0)
            {
                _context.ExpensesTable.Add(model);
            } else
            {
                _context.ExpensesTable.Update(model);
            }

                _context.SaveChanges();

            return RedirectToAction("Expenses");
        }

        public IActionResult DeleteExpense(int id)
        {
            var expenseToDelete = _context.ExpensesTable.SingleOrDefault(expense => expense.Id == id);
            if (expenseToDelete != null)
            {
                _context.ExpensesTable.Remove(expenseToDelete);
                _context.SaveChanges();
            }
            return RedirectToAction("Expenses");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
