using System.ComponentModel.DataAnnotations;

namespace dinamicasAgile.Models
{
    public class Passo
    {
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }
    }
}