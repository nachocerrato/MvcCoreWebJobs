using MvcCoreWebJobs.Data;
using MvcCoreWebJobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreWebJobs.Repositories
{
    public class RepositoryChollos
    {
        private ChollosContext context;
        public RepositoryChollos(ChollosContext context)
        {
            this.context = context;
        }

        public List<Chollo> GetChollos()
        {
            var consulta = from datos in this.context.Chollos
                           orderby datos.IdChollo descending
                           select datos;
            return consulta.ToList();
        }

    }
}
