using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFinal_InforQui.Models
{
    public class Produtos
    {
        //O identificador da tabela Produtos
        public int ProdutosID { get; set; }
        //O nome do produto
        public string Nome { get; set; }
        //A descrição do produto
        public string Descricao { get; set; }
        //O preço do produto
        public char Preco { get; set; }
        //A marca do produto
        public string Marca { get; set; }
        //A imagem do produto
        public Byte Imagem { get; set; }
        //O tipo do produto
        public string Tipo { get; set; }
    }
}