using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using dinamicasAgile.Extensions;

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

        public virtual IList<TipoDinamica> Tipos {get;set;}

        public InformacoesBasicas()
        {
            this.Tipos = new List<TipoDinamica>();
        }

        public string TiposFormatados() {
            if(Tipos.Count() == 0) {
                return "";
            }
            StringBuilder tipos = new StringBuilder();
            string nomeTipo = Tipos[0].Tipo.DisplayName();
            tipos.Append(nomeTipo);
            for(int i = 1; i < Tipos.Count; i++) {
                nomeTipo = Tipos[i].Tipo.DisplayName();
                tipos.Append(", " + nomeTipo);
            }
            return tipos.ToString();
        }
    }
}