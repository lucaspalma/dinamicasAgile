using System.Collections.Generic;

namespace dinamicasAgile.Models
{
    public class Dinamica
    {
        public int Id { get; set; }

        public InformacoesBasicas Resumo { get; set; }

        public Fluxo Fluxo { get; set; }

        public IList<Exemplo> Exemplos { get; set; }

        public IList<Referencia> Referencias { get; set; }

        public Dinamica()
        {
            this.Exemplos = new List<Exemplo>();
            this.Referencias = new List<Referencia>();
        }
    }
}