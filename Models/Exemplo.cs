using System.ComponentModel.DataAnnotations;

namespace dinamicasAgile.Models
{
    public class Exemplo
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Poxa, avalia aí")]
        public string Avaliacao { get; set; }

        [Required(ErrorMessage="Fala aí quem participou da dinâmica")]
        [MinLength(2, ErrorMessage="Este campo precisa de pelo menos {1} caracteres")]
        public string Participante { get; set; }

        [Required(ErrorMessage="Tenta lembrar quanto tempo levou")]
        public string Tempo { get; set; }

        [Required(ErrorMessage="O contexto é bem importante")]
        [MinLength(5, ErrorMessage="O contexto precisa de pelo menos {1} caracteres")]
        public string Contexto { get; set; }

        [Required(ErrorMessage="Com certeza teve um motivo, conta pra gente")]
        [MinLength(5, ErrorMessage="O motivo precisa de pelo menos {1} caracter")]
        public string Motivo { get; set; }

        public string Metrica { get; set; }

        public string Observacao { get; set; }
    }
}