using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dinamicasAgile.Models
{
    public class Dinamica
    {
        public int Id { get; set; }

        [Required(ErrorMessage="O resumo é obtigatório")]
        public InformacoesBasicas Resumo { get; set; }

        [Required(ErrorMessage="O fluxo é obrigatório")]
        public Fluxo Fluxo { get; set; }

        [Required(ErrorMessage="O exemplo é obrigatório")]
        [MinLength(1, ErrorMessage="Precisa de pelo menos {1} exemplo(s)")]
        public IList<Exemplo> Exemplos { get; set; }

        public IList<Referencia> Referencias { get; set; }

        public Dinamica()
        {
            this.Exemplos = new List<Exemplo>();
            this.Referencias = new List<Referencia>();
        }
    }
}