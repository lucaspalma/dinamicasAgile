using System.ComponentModel.DataAnnotations;

namespace dinamicasAgile.Models
{
    public enum TipoDinamica : int
    {
        [Display(Name="Ice breaker")]
        IceBreaker = 0,

        [Display(Name="Coleta de dados")]
        ColedaDeDados = 1,

        [Display(Name="Team building")]
        TeamBuilding = 2,

        [Display(Name="Retrospectiva")]
        Retrospectiva = 3,

        [Display(Name="Futurospectiva")]
        Futurospectiva = 4,

        [Display(Name="Filtro")]
        Filtro = 5,

        [Display(Name="Feedback")]
        Feedback = 6,

        [Display(Name="Planejamento")]
        Planejamento = 7,

        [Display(Name="Review/Revisão")]
        Review = 8,

        [Display(Name="Refinamento")]
        Refinamento = 9

    }
}