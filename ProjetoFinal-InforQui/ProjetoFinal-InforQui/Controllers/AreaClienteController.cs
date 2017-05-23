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
    public class AreaClienteController : Controller
    {
        private InforQuiDB db = new InforQuiDB();

        // GET: AreaCliente/
        public ActionResult Index(string Procurar)
        {
            var produtos = from s in db.Produtos
                           select s;
            if (!String.IsNullOrEmpty(Procurar))
            {
                produtos = produtos.Where(s => s.Nome.Contains(Procurar));               
            }


            List<SelectListItem> item = new List<SelectListItem>();
            item.Add(new SelectListItem { Text = "Instrumento", Value = "1" });
            item.Add(new SelectListItem { Text = "Material", Value = "2" });

            ViewBag.tipoProduto = item; 


            return View(produtos.ToList());
        }
        

        // GET: AreaCliente/Detalhes/5
        public ActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produtos produtos = db.Produtos.Find(id);
            if (produtos == null)
            {
                return HttpNotFound();
            }
            return View(produtos);
        }

    }
}
