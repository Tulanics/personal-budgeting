using BudgetAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BudgetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseController
    {
        public static List<Expense> expenses = new List<Expense>();

        public void AddsBudgetExpense(Expense expense) 
        {
            expenses.Add(expense);
            Console.WriteLine(expense.Id);
            Console.WriteLine(expense.Description);
            Console.WriteLine(expense.Amount);
            Console.WriteLine(expense.Date.Date);
        }
    }
}
