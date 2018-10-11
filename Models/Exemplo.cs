using System.ComponentModel.DataAnnotations;

namespace dinamicasAgile.Models
{
    public class Exemplo
    {
        public int Id { get; set; }

        [Required]
        public string Avaliacao { get; set; }

        [Required]
        [MinLength(2)]
        public string Participante { get; set; }

        [Required]
        public string Tempo { get; set; }

        [Required]
        [MinLength(5)]
        public string Contexto { get; set; }

        [Required]
        [MinLength(5)]
        public string Motivo { get; set; }

        public string Metrica { get; set; }

        public string Observacao { get; set; }
    }
}