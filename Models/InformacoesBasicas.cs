using System.ComponentModel.DataAnnotations;

namespace dinamicasAgile.Models
{
    public class InformacoesBasicas
    {
        public int Id { get; set; }
        
        [Required]
        [MinLength(2)]
        public string Titulo { get; set; }

        public string Material { get; set; }

        [Required]
        public string Duracao { get; set; }
        
        [Required]
        [MinLength(2)]
        public string Proposito { get; set; }

        [Required]
        public string Tipo { get; set; }
    }
}