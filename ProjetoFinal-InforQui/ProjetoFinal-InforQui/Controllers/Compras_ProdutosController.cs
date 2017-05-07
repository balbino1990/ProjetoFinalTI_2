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
    public class Compras_ProdutosController : Controller
    {
        private InforQuiDB db = new InforQuiDB();

        // GET: Compras_Produtos
        public ActionResult Index()
        {
            var compras_Produtos = db.Compras_Produtos.Include(c => c.Compra).Include(c => c.Produto);
            return View(compras_Produtos.ToList());
        }

        public ActionResult AdicionarCarrinho(int id)
        {
         
            List<Compras_Produtos> carrinho = Session["Carrinho"] != null ? (List<Compras_Produtos>)Session["Carrinho"] : new List<Compras_Produtos>();

            Produtos d = db.Produtos.Find(id);

            if (d != null)
            {
                Compras_Produtos i = new Compras_Produtos();
                i.Produto = d;
                i.Quantidade = 1;
                i.ProdutoFK = d.ProdutoID;

                if (carrinho.Where(x => x.ProdutoFK == d.ProdutoID).FirstOrDefault() != null)
                {
                    carrinho.Where(x => x.ProdutoFK == d.ProdutoID).FirstOrDefault().Quantidade += 1;
                }

                else
                {
                    carrinho.Add(i);


                }
                Session["Carrinho"] = carrinho;

            }

            return RedirectToAction("Carrinho");

        }



        public ActionResult MostraProduto()
        {
            List<Compras_Produtos> carrinho = Session["Carrinho"] != null ? (List<Compras_Produtos>)Session["Carrinho"] : new List<Compras_Produtos>();

            return View(carrinho);
        }
    }
    }

