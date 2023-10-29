using System.ComponentModel.DataAnnotations;

namespace BudgetAPI.Models
{
    public class Expense
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "A Descrição da despesa é obrigatória")]
        public string Description { get; set; }

        [Required(ErrorMessage = "O valor da despesa é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "o valor da despesa não pode ser negativo")]
        public double Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
