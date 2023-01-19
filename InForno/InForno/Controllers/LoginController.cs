using InForno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InForno.Controllers
{
    public class LoginController : Controller
    {
        ModelDbContext context = new ModelDbContext();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        // Post: Login
        [HttpPost]
        public ActionResult Login(UtentiTab utente) 
        {
            try { 
                if(utente)
                if(ModelState.IsValid) 
                { 
                context.UtentiTab.Add(utente);
                }
            }catch(Exception ex)
            {
                alert(ex.ToString());
            }
            return RedirectToAction("Index", "Home");
        }
        private void alert(string v)
        {
            throw new NotImplementedException();
        }
    }
}
