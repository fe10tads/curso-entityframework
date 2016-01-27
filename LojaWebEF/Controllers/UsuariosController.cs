using LojaWebEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaWebEF.DAO;

namespace LojaWebEF.Controllers
{
    public class UsuariosController : Controller
    {
        private UsuariosDAO usuariosDao;

        public UsuariosController(UsuariosDAO usuariosDao)
        {
            this.usuariosDao = usuariosDao;
        }
        //
        // GET: /Usuarios/

        public ActionResult Index()
        {
            IEnumerable<Usuario> usuarios = usuariosDao.Lista();
            return View(usuarios);
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(Usuario usuario)
        {
            usuariosDao.Adiciona(usuario);
            
            return RedirectToAction("Index");
        }

        public ActionResult Remove(int id)
        {
            Usuario usuario = usuariosDao.BuscaPorId(id);
            usuariosDao.Remove(usuario);
            
            return RedirectToAction("Index");
        }

        public ActionResult Visualiza(int id)
        {
            Usuario usuario = usuariosDao.BuscaPorId(id);
            return View(usuario);
        }

        public ActionResult Atualiza(Usuario usuario)
        {
            usuariosDao.Atualiza(usuario);
            return RedirectToAction("Index");
        }

    }
}
