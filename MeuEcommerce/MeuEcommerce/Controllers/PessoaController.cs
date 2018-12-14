using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeuEcommerce.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Eu(String id)
        {
            ViewBag.id = id; 
            return View();
        }
        public ActionResult Voce()
        {
            return View();
        }
    }
}