using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject.Web.Mvc.FilterBindingSyntax;
using Microsoft.Ajax.Utilities;

namespace LojaWebEF.Filters
{
    public class SaveChangesFilter : System.Web.Mvc.ActionFilterAttribute
    {

        private EntidadesContext contexto;
        public SaveChangesFilter(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }
        
        public override void OnResultExecuted(ResultExecutedContext contexto)
        {
            if (contexto.Exception == null)
            {
                this.contexto.SaveChanges();
            }
            this.contexto.Dispose();
        }
    }
}