using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinal_InforQui.Models
{
    public class Login
    {
        public int LoginID { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        [Display(Name = "Lembro-me da próxima vez.")]
        public bool LembroMe { get; set; }
    }
}