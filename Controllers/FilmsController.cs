using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcSakilaCore.Controllers
{
    public class FilmsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            SakilaContext context = HttpContext.RequestServices.GetService(typeof(WebApplication3.Models.SakilaContext)) as SakilaContext;

            return View(context.GetAllFilms());
        }
    }
}