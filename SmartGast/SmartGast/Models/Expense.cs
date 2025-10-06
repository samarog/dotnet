using System.ComponentModel.DataAnnotations;

namespace SmartGast.Models
{
    public class Expense
    {
        public int Id { get; set; } // we need a PK in SQL to track unique values
        public decimal Value { get; set; } // Aqui não precisamos de um Required porque o default é zero

        [Required] // obriga a colocar um valor na descrição
        public string? Description { get; set; } // can be null
    }
}
