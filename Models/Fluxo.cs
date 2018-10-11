using System.Collections.Generic;

namespace dinamicasAgile.Models
{
    public class Fluxo
    {
        public int Id { get; set; }
        public IList<Passo> Passos { get; set; }

        public Fluxo()
        {
            this.Passos = new List<Passo>();
        }
    }
}