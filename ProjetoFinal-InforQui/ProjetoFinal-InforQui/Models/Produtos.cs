﻿using System;
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
        [RegularExpression("[A-ZÁÉÍOÚÇÂÂÀÈÌÒÙa-záéíóúàèìòùçâã][A-ZÁÉÍOÚÇÂÂÀÈÌÒÙa-záéíóúàèìòùçâã0-9]*[ A-ZÁÉÍOÚÇÂÂÀÈÌÒÙa-záéíóúàèìòùçâã0-9,'.%]*", 
                            ErrorMessage = "O campo do {0} não permite o algarismo e letra minúscula no inicio do nome e permite os caracteres português")]
        public string Nome { get; set; }
        
        //A descrição do produto
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Descrição do produto")]
        [RegularExpression("[A-ZÁÉÍOÚÇÂÂÀÈÌÒÙa-záéíóúàèìòùçâã0-9][A-ZÁÉÍOÚÇÂÂÀÈÌÒÙa-záéíóúàèìòùçâã0-9]*[ A-ZÁÉÍOÚÇÂÂÀÈÌÒÙa-záéíóúàèìòùçâã0-9.'+*-_,?={}?/``´´%@#&:;]*",
                          ErrorMessage = "O campo do {0} não permite no ínicio da descrição com letra minúscula")]
        public string Descricao { get; set; }
        
        //O preço do produto
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [RegularExpression("[€][0-9]+[,]([0-9]{2})", 
                          ErrorMessage = "O preço do produto tem de ser usar a moeda euro (€) e tem de ter dois digitos decimais ultimos")]
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