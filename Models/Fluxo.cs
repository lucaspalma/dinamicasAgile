using System.Collections.Generic;

namespace dinamicasAgile.Models
{
    public class Fluxo
    {
        public IList<string> Passos { get; set; }

        public Fluxo()
        {
            this.Passos = new List<string>();
        }
    }
}