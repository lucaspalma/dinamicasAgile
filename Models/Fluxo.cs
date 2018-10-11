using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dinamicasAgile.Models
{
    public class Fluxo
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Os passos são obrigatórios")]
        [MinLength(1, ErrorMessage="O fluxo precisa ter pelo menos {1} passo")]
        public IList<Passo> Passos { get; set; }

        public Fluxo()
        {
            this.Passos = new List<Passo>();
        }
    }
}