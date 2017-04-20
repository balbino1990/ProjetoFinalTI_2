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
    public class ProdutosController : Controller
    {
        private InforQuiDB db = new InforQuiDB();

        // GET: Produtos
        public ActionResult Index()
        {
            //vai retornar para o 'VIEW', a lista da tabela 'Produtos' na base de dados 'InforQui'
            //e vai ordenar por o 'Nome' do produto
            return View(db.Produtos.ToList().OrderBy(d=>d.Nome));
        }

        // GET: Produtos/Detalhes/5
        public ActionResult Detalhes(int? id)
        {
            // Se o 'id' do produto igual a nulo
            if (id == null)
            {
                // retorna um 'erro' do estado Http
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Se não, vai encontrar ou criar um novo 'id' para a tabela 'Produto'
            Produtos produtos = db.Produtos.Find(id);
            // Se este 'id' novo que foi criado, for igual a nulo
            if (produtos == null)
            {
                //vai retornar um 'erro' de Http que disse: "não existe"
                return HttpNotFound();
            }
            //Se não, vai retornar para o 'View' os produtos na tabela
            return View(produtos);
        }

        // GET: Produtos/Criar
        public ActionResult Criar()
        {
            // retorna para o 'VIEW' 
            return View();
        }

        // POST: Produtos/Criar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar([Bind(Include = "ProdutosID,Nome,Descricao,Marca,Imagem,Tipo")] Produtos produtos, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    file.SaveAs(HttpContext.Server.MapPath("~/Content/Imagens/") + file.FileName);
                    produtos.Imagem = file.FileName;
                }
                db.Produtos.Add(produtos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(produtos);
        }

        // GET: Produtos/Edit/5
        public ActionResult Editar(int? id)
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

        // POST: Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar([Bind(Include = "ProdutosID,Nome,Descricao,Marca,Imagem,Tipo")] Produtos produtos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produtos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produtos);
        }

        // GET: Produtos/Delete/5
        public ActionResult Apagar(int? id)
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

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("APagar")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produtos produtos = db.Produtos.Find(id);
            db.Produtos.Remove(produtos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
