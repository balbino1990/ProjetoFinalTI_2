using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinal_InforQui.Models
{
    public class Compras
    {
        //##################O construtor da classe###########################
        public Compras()
        {
            ListaComprasProdutos = new HashSet<Compras_Produtos>();
        }
        //##################Os stributos da tabela Compras#####################
        //O identificador da tabela Compras
        public int ComprasID { get; set; }
        //O atributo data para fazer a compra
        public DateTime Data { get; set; }
        
        //########### Relacionamentos e chaves estrangeiras####################
        //chave estrangeira das compras
        [ForeignKey("Utilizador")]
        //existe para criar a FK na BD
        public int UtilizadorFK { get; set; }
        //relacionamento entre a tabela Compras com a tabela utilizadores
        public Utilizadores Utilizador { get; set; }

        //Relacionamento entre a tabela Compras com a tabela Compras_Produtos
        // 1 'Compra' relacionar com muitas 'Compras_Produtos'
        public virtual ICollection<Compras_Produtos> ListaComprasProdutos { get; set; }
    }
}