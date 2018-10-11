using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using dinamicasAgile.Banco;
using dinamicasAgile.Models;
using Microsoft.EntityFrameworkCore;

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

        public Dinamica BuscaPorId(int id)
        {
            return contexto.Dinamicas.Find(id);
        }

        public IList<Dinamica> BuscaTodasApenasComInfosBasicas()
        {
            return contexto.Dinamicas.Include(d => d.Resumo).ToList();
        }
    }
}