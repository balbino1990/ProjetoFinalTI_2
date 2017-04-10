using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFinal_InforQui.Models
{
    public class Utilizadores
    {
        //O identificador da tabela Utilizador
        public int UtilizadoresID { get; set; }
        //O atributo Nome
        public string Nome { get; set; }
        //O atributo Apelido
        public string Apelido { get; set; }
        //O atributo Email
        public string Email { get; set; }
        //O atributo Password
        public string Password { get; set; }
        //O atributo para confirmar o password
        public string ConfirmPassword { get; set; }
        //O atributo do Genero
        public char Genero { get; set; }
        //O atributo data de nascimento
        public int DataNascimento { get; set; }
        //O atributo morada
        public string Morada { get; set; }
        //O atributo de conttacto de utilizador
        public int Contacto { get; set; }
        //O atributo de imagem dos produtos (este atributo vai ser facultativo)
        public Byte Imagem { get; set; }
    }
}