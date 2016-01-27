using LojaWebEF.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LojaWebEF.DAO
{
    public class UsuariosDAO
    {
        private EntidadesContext contexto;

        public UsuariosDAO(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }

        public void Adiciona(Usuario usuario)
        {
            this.contexto.Usuarios.Add(usuario);
        }

        public void Remove(Usuario usuario)
        {
            this.contexto.Usuarios.Remove(usuario);
        }

        public void Atualiza(Usuario usuario)
        {
            this.contexto.Entry(usuario).State = EntityState.Modified;
        }

        public Usuario BuscaPorId(int id)
        {
            return contexto.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> Lista()
        {
            return this.contexto.Usuarios;
        }
    }
}