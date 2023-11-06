using BudgetAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BudgetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseController
    {
        public static List<Expense> expenses = new List<Expense>();
        private static int id = 1;

        public void AddsBudgetExpense(Expense expense) 
        {
            expense.Id = id++;
            expenses.Add(expense);
            Console.WriteLine(expense.Id);
            Console.WriteLine(expense.Description);
            Console.WriteLine(expense.Amount);
            Console.WriteLine(expense.Date.Date);
        }

        [HttpGet]
        public IEnumerable<Expense> GetBudgetIncomes()
        {
            return expenses;
        }

        [HttpGet("{id}")]
        public Expense? GetExpensebyId(int id)
        {
            return expenses.FirstOrDefault(expense => expense.Id == id);
        }
    }
}
