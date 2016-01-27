using LojaWebEF.Entidades;
using LojaWebEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaWebEF.DAO;

namespace LojaWebEF.Controllers
{
    public class CategoriasController : Controller
    {
        private CategoriasDAO categoriasDao;

        public CategoriasController(CategoriasDAO categoriasDao)
        {
            this.categoriasDao = categoriasDao;
        }
        //
        // GET: /Categorias/

        public ActionResult Index()
        {
            IEnumerable<Categoria> categorias = categoriasDao.Lista();
            return View(categorias);
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(Categoria categoria)
        {
            categoriasDao.Adiciona(categoria);

            return RedirectToAction("Index");
        }

        public ActionResult Remove(int id)
        {
            Categoria categoria = categoriasDao.BuscaPorId(id);
            categoriasDao.Remove(categoria);
            
            return RedirectToAction("Index");
        }

        public ActionResult Visualiza(int id)
        {
            Categoria categoria = categoriasDao.BuscaPorId(id);
            return View(categoria);
        }

        public ActionResult Atualiza(Categoria categoria)
        {
            categoriasDao.Atualiza(categoria);
            return RedirectToAction("Index");
        }   

        public ActionResult CategoriasEProdutos()
        {
            IEnumerable<Categoria> categorias = new List<Categoria>();
            return View(categorias);
        }

        public ActionResult BuscaPorNome(string nome)
        {
            ViewBag.Nome = nome;

            IEnumerable<Categoria> categorias = new List<Categoria>();
            return View(categorias);
        }

        public ActionResult NumeroDeProdutosPorCategoria()
        {
            IEnumerable<ProdutosPorCategoria> produtosPorCategoria = new List<ProdutosPorCategoria>();
            return View(produtosPorCategoria);
        }
    }
}
