using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFinal_InforQui.Models
{
    public class Utilizadores
    {
        public int UtilizadoresID { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public char Genero { get; set; }

        public int DataNascimento { get; set; }

        public string Morada { get; set; }

        public int Contacto { get; set; }

        public Byte Imagem { get; set; }
    }
}