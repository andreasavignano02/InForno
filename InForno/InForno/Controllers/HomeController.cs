using InForno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace InForno.Controllers
{
    public class HomeController : Controller
    {
        ModelDbContext Context = new ModelDbContext();
        public ActionResult Index()
        {
            List<ListaPizze> lista = Context.ListaPizze.ToList();
            return View(lista);
        }
        [Authorize]
        public ActionResult Details(int id)
        {
                return View(Context.ListaPizze.Find(id));         
        }
    }
}
