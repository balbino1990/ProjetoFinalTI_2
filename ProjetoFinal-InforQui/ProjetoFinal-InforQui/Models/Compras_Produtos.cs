using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinal_InforQui.Models
{
    public class Compras_Produtos
    {

        //################## Os atributos da tabela Compras_produtos #########
        //O identificador da tabela Compras_Produtos
        public int Compras_ProdutosID { get; set; }
        //A quantidade da compra dos produtos
        public int Quantidade { get; set; }
        //O preço dos produtos comprado
        public char Preco { get; set; }

        //######### Relacionamentos e Chaves estrangeiras ###################
        //chave estrangeira da tabela Compras_Produtos
        [ForeignKey("Compra")]
        //existe para criar a FK na BD
        public int CompraFK { get; set; }
        //Relacionamento entre a tabela Compra com a tabela Compras_Produtos
        public Compras Compra { get; set; }

        //chave estrangeira da tabela Produtos
        [ForeignKey("Produto")]
        //existe para criar a FK na BD
        public int ProdutoFK { get; set; }
        //Relacionamento entre a tabela Produto com a tabela Compras_Produtos
        public Produtos Produto { get; set; }
    }
}