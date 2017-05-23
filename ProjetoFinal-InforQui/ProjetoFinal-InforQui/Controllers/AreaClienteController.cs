using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using ProjetoFinal_InforQui.Models;

namespace ProjetoFinal_InforQui.Controllers
{
    public class AreaClienteController : Controller
    {
        private InforQuiDB db = new InforQuiDB();

        // GET: AreaCliente
        public ActionResult Index(string Procurar, int? pagina)
        {
            


            List<SelectListItem> item = new List<SelectListItem>();
            item.Add(new SelectListItem { Text = "Instrumento", Value = "1" });
            item.Add(new SelectListItem { Text = "Material", Value = "2" });

            ViewBag.tipoProduto = item;


            //#########################################################
            //#####Fazer a paginação dos produtos######################
            int tamanhoPagina = 5;
            int numeroPagina = pagina ?? 1;     // o número da pagina for nulo, vamos inserir um


            return View(db.Produtos.OrderBy(p=> p.Nome).ToPagedList(numeroPagina, tamanhoPagina));
        }
        
        //GET: AreaCliente/Listar
        public ActionResult Listar()
        {
            return View();
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
