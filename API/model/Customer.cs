
using System.ComponentModel.DataAnnotations;

namespace API.model
{
    public class Customer
    {

        [Required]
        [Range(1, Int32.MaxValue)]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cpf { get; set; }

        [Required]
        [Range(1, Int32.MaxValue)]
        public Decimal Salario { get; set; }
    }
}