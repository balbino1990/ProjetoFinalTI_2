using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFinal_InforQui.Models
{
    public class Utilizadores
    {
        //#####################################################
        //O construtor da classe Utilizadores
        public Utilizadores()
        {
            ListaDeCompras = new HashSet<Compras>();
        }
        
        //####################################################
        //##########Os atributos da tabela Compras############
        //####################################################
        //O identificador da tabela Utilizador
        public int UtilizadoresID { get; set; }
        //O Nome do utilizador
        public string Nome { get; set; }
        //O Apelido do utilizador
        public string Apelido { get; set; }
        //O Email do utilizador
        public string Email { get; set; }
        //O Password do utilizador
        public string Password { get; set; }
        //O confirmar do password do utilizador
        public string ConfirmPassword { get; set; }
        //O Genero do utilizador
        public char Genero { get; set; }
        //A data de nascimento do utilizador
        public int DataNascimento { get; set; }
        //A Morada do utilizador
        public string Morada { get; set; }
        //O Contacto do utilizador
        public int Contacto { get; set; }
        //O Imgem do utilizador(este atributo vai ser facultativo)
        public Byte Imagem { get; set; }

        //##################################################################
        //################Relacionamento e chaves estrangeiras##############
        //##################################################################
        //1 Utilizador relaciona com muitas Compras
        public virtual ICollection<Compras> ListaDeCompras { get; set; }
    }
}