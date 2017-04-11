using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoFinal_InforQui.Models;

namespace ProjetoFinal_InforQui.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index
        public ActionResult Index()
        {
            return View();
        }

        //GET: Home/Utilizador
        public ActionResult Utilizador()
        {
            return View();
        }

        //GET: Home/Sobre
        public ActionResult Sobre()
        {
            return View();
        }

        //GET: Home/Contactos
        public ActionResult Contactos()
        {
            return View();
        }
        
    }
}
