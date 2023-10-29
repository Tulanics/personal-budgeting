using BudgetAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BudgetAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class IncomeController : ControllerBase
{
    private static List<Income> incomes = new List<Income>();

    [HttpPost]
    public void AddsBudgetIncome([FromBody]Income income)
    {
        incomes.Add(income);
        Console.WriteLine(income.Id);
        Console.WriteLine(income.Description);
        Console.WriteLine(income.Amount);
        Console.WriteLine(income.Date);
    }
}
