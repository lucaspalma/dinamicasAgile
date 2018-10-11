using dinamicasAgile.Banco;
using dinamicasAgile.Models;

namespace dinamicasAgile.DAO
{
    public class DinamicaDao
    {
        private readonly DinamicaContext contexto;

        public DinamicaDao(DinamicaContext contexto)
        {
            this.contexto = contexto;
        }

        public void Salva(Dinamica dinamica) {
            contexto.Dinamicas.Add(dinamica);
            contexto.SaveChanges();
        }
    }
}