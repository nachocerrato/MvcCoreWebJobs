using Microsoft.EntityFrameworkCore;
using MvcCoreWebJobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreWebJobs.Data
{
    public class ChollosContext: DbContext
    {
        public ChollosContext(DbContextOptions<ChollosContext> options)
            : base(options) { }
        public DbSet<Chollo> Chollos { get; set; }

    }
}
