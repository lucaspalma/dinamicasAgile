using System.ComponentModel.DataAnnotations;

namespace dinamicasAgile.Models
{
    public class InformacoesBasicas
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage="O título da dinâmica é obrigatório")]
        [MinLength(2, ErrorMessage="O título precisa conter pelo menos {1} caracteres")]
        public string Titulo { get; set; }

        public string Material { get; set; }

        [Required(ErrorMessage="A duração é obrigatória")]
        public string Duracao { get; set; }
        
        [Required(ErrorMessage="O propósito é obrigatório")]
        [MinLength(2, ErrorMessage="O propósito precisa conter pelo menos {1} caracteres")]
        public string Proposito { get; set; }

        [Required(ErrorMessage="O tipo é obrigatório")]
        public string Tipo { get; set; }
    }
}