using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFinal_InforQui.Models
{
    public class Login
    {
        //O identificador da tabela Login
        public int LoginID { get; set; }
        //O Email do Login de utilizador
        public string Email { get; set; }
        //O Password do Login de utilizador
        public string Password { get; set; }
    }
}