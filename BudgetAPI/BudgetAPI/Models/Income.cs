using System.ComponentModel.DataAnnotations;

namespace BudgetAPI.Models
{
    public class Income
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "A Descrição da receita é obrigatória")]
        public string Description { get; set; }

        [Required(ErrorMessage = "O valor da receita é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "o valor da receita não pode ser negativo")]
        public double Amount { get; set; }
        
        [Required]
        
        public DateTime Date { get; set; }
    }
}
