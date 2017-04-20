using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinal_InforQui.Models
{
    public class Produtos
    {
        //################ O construtor da classe####################
        public Produtos()
        {
            ListaComprasProdutos = new HashSet<Compras_Produtos>();
        }

        //############ Os atributos da tabela Produtos################
        //O identificador da tabela Produtos
        public int ProdutosID { get; set; }
        //O nome do produto
        public string Nome { get; set; }
        //A descrição do produto
        public string Descricao { get; set; }
        //O preço do produto
        public string Preco { get; set; }
        //A marca do produto
        public string Marca { get; set; }
        //A imagem do produto
        public string Imagem { get; set; }
        //O tipo do produto
        public string Tipo { get; set; }

        //########## Relacionamentos e chaves estrangeiras
        //Relacionamento entre a tabela Produto e Compras_Produtos
        //1 'Produto' relacionar com muitas 'Compras_Produtos'
        public virtual ICollection<Compras_Produtos> ListaComprasProdutos { get; set; }
    }
}