using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFinal_InforQui.Models
{
    public class Compras_Produtos
    {
        //O identificador da tabela Compras_Produtos
        public int Compras_ProdutosID { get; set; }
        //A quantidade da compra dos produtos
        public int Quantidade { get; set; }
        //O preço dos produtos comprado
        public char Preco { get; set; }
    }
}