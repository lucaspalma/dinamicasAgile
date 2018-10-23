using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using dinamicasAgile.Banco;
using dinamicasAgile.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

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

        public void CadastraExemplo(int idDinamica, Exemplo exemplo)
        {
            Dinamica dinamica = contexto.Dinamicas.Find(idDinamica);
            dinamica.Exemplos.Add(exemplo);
            contexto.SaveChanges();
        }

        public IList<Dinamica> BuscaTodasApenasComInfosBasicas()
        {
            return contexto.Dinamicas.Include(d => d.Resumo).Where(d => d.Arquivada == false).ToList();
        }

        public void Edita(Dinamica dinamica)
        {
            contexto.Database.ExecuteSqlCommand("delete from TiposDinamicas where InformacoesBasicasId = @resumoId", new MySqlParameter("resumoId", dinamica.Resumo.Id));
            contexto.Dinamicas.Update(dinamica);
            contexto.SaveChanges();
        }

        public void Arquivar(int id)
        {
            Dinamica dinamica = contexto.Dinamicas.Find(id);
            dinamica.Arquivada = true;
            contexto.SaveChanges();
        }
    }
}