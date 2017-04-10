using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoFinal_InforQui.Models
{
    //o DbContext é a superclasse do entity

    public class InforQuiDB : DbContext
    {
        //representar a Base de Dados descrevendo as tabelas que lá estão contidas

        //representar o 'construtor' desta classe
        //identifica onde se encontra a base de dados
        public InforQuiDB() : base("InforQuiDBConnection") { }

        //descrever as tabelas que estão na base de dados

        //tabela de Utilizadores
        public virtual DbSet<Utilizadores> Utilizadores { get; set; }
        //tabela de Produtos
        public virtual DbSet<Produtos> Produtos { get; set; }
        //tabela de Compras_Produtos
        public virtual DbSet<Compras_Produtos> Compras_Produtos { get; set; }
        //tabela de Compras
        public virtual DbSet<Compras> Compras { get; set; }
        //tabela de Login de utilizador
        public virtual DbSet<Login> Login { get; set; }
    }
}