using LojaWebEF.Entidades;
using LojaWebEF.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LojaWebEF.DAO
{
    public class CategoriasDAO
    {
        private EntidadesContext contexto;

        public CategoriasDAO(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }

        public void Adiciona(Categoria categoria)
        {
            this.contexto.Categorias.Add(categoria);
            //contexto.SaveChanges();
        }

        public void Remove(Categoria categoria)
        {
            this.contexto.Categorias.Remove(categoria);
        }

        public void Atualiza(Categoria categoria)
        {
            this.contexto.Entry(categoria).State = EntityState.Modified;
        }

        public Categoria BuscaPorId(int id)
        {
            return contexto.Categorias.Find(id);
        }

        public IEnumerable<Categoria> Lista()
        {
            return this.contexto.Categorias;
        }

        public IEnumerable<Categoria> BuscaPorNome(string nome)
        {
            return new List<Categoria>();
        }

        public IEnumerable<ProdutosPorCategoria> ListaNumeroDeProdutosPorCategoria()
        {
            return new List<ProdutosPorCategoria>();
        }
    }

}