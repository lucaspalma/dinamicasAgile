using System.ComponentModel.DataAnnotations;

namespace dinamicasAgile.Models
{
    public class TipoDinamica
    {
        public int Id { get; set; }

        [Required]
        public Tipo Tipo { get; set; }

        public override string ToString(){
            return Tipo.ToString();
        }  
    }
}