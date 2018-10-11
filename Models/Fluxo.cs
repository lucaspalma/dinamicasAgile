using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dinamicasAgile.Models
{
    public class Fluxo
    {
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        public IList<Passo> Passos { get; set; }

        public Fluxo()
        {
            this.Passos = new List<Passo>();
        }
    }
}