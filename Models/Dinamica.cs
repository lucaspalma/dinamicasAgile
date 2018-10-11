using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dinamicasAgile.Models
{
    public class Dinamica
    {
        public int Id { get; set; }

        [Required]
        public InformacoesBasicas Resumo { get; set; }

        [Required]
        public Fluxo Fluxo { get; set; }

        [Required]
        [MinLength(1)]
        public IList<Exemplo> Exemplos { get; set; }

        public IList<Referencia> Referencias { get; set; }

        public Dinamica()
        {
            this.Exemplos = new List<Exemplo>();
            this.Referencias = new List<Referencia>();
        }
    }
}