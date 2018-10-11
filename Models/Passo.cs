using System.ComponentModel.DataAnnotations;

namespace dinamicasAgile.Models
{
    public class Passo
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Preencha esse passo do fluxo")]
        public string Descricao { get; set; }
    }
}