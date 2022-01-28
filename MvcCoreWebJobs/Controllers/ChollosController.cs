using Microsoft.AspNetCore.Mvc;
using MvcCoreWebJobs.Models;
using MvcCoreWebJobs.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreWebJobs.Controllers
{
    public class ChollosController : Controller
    {
        private RepositoryChollos repo;
        public ChollosController(RepositoryChollos repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(this.repo.GetChollos());
        }
    }
}
