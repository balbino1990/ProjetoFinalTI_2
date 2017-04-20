using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoFinal_InforQui.Models;

namespace ProjetoFinal_InforQui.Controllers
{
    public class UtilizadorController : Controller
    {
        private InforQuiDB db = new InforQuiDB();



        // GET: Registar/Utilizador
        public ActionResult Registar()
        {
            return View();
        }

        // POST: Registar/Utilizador
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registar(Utilizadores conta)
        {
            if (ModelState.IsValid)
            {
                db.Utilizadores.Add(conta);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");

            }

            return View();
        }

        // GET: Login/Utilizador
        public ActionResult Login()
        {
            return View();
        }

        //POST: Login/Utilizador
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Utilizadores utilizador)
        {
            if (ModelState.IsValid)
            {
                using (InforQuiDB infor = new InforQuiDB())
                {
                    var v = infor.Login.Where(a => a.Email.Equals(utilizador.Email) && a.Password.Equals(utilizador.Password)).FirstOrDefault();
                    //Session["LogedUserID"] = v.LoginID.ToString();
                    //Session["LogedUserFullName"] = v.Email.ToString();
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(utilizador);
        }
    }
}