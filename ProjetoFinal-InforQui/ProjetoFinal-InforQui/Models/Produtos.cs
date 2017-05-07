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
        [Key]
        [Display(Name = "Identifcador do Produto")]
        public int ProdutoID { get; set; }
        //O nome do produto
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Nome do produto")]
        public string Nome { get; set; }
        //A descrição do produto
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Descrição do produto")]
        public string Descricao { get; set; }
        //O preço do produto
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Preço do produto")]
        public string Preco { get; set; }
        //A imagem do produto
        //[Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Imagem do produto")]
        public string Imagem { get; set; }
        //O tipo do produto
        //[Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Tipo do produto")]
        public string Tipo { get; set; }

        //########## Relacionamentos e chaves estrangeiras
        //Relacionamento entre a tabela Produto e Compras_Produtos
        //1 'Produto' relacionar com muitas 'Compras_Produtos'
        public virtual ICollection<Compras_Produtos> ListaComprasProdutos { get; set; }
    }
}