using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinal_InforQui.Models
{
    public class Logins
    {
        //O identificador da Tabela Logins
        public int LoginsID { get; set; }
        //O atributo Email
        public string Email { get; set; }
        //O atributo Password
        public string Password { get; set; }
        //O atributo para lembrar o utilizador para o proximo autenticação
        [Display(Name = "Lembro-me da próxima vez.")]
        public bool LembroMe { get; set; }
    }
}