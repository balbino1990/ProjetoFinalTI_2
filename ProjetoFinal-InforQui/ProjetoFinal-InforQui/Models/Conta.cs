﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinal_InforQui.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    //#############################################################################
    //Classe para registar os dados dos utilizadores
    //#############################################################################
    public class Registo
    {
        //####################################################
        //##########Os atributos da tabela utilizador#########
        //####################################################
        
        //O Nome do utilizador
        [Required(ErrorMessage = "{0} é obrigatoria")]
        [Display(Name = "Nome Completo")]
        [RegularExpression("[A-Z][a-záéíóúàèìòùãõäëïöüçñ]+((( )|(-)|( (e|de|da|dos) )|( d'))[A-Z][a-záéíóúàèìòùãõäëïöüçñ]+){1,3}",
                          ErrorMessage = "Deve escrever o {0} só com letras. Pode usar um espaço em branco entre palavras. Deve começar cada nome com uma maiúscula, seguida de minúsculas.")]
        public string Nome { get; set; }

        //O Email do utilizador
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Email de utilizador")]
        [RegularExpression("[A-Za-z][A-Za-z0-9._%+-]+@inforqui.com",
                          ErrorMessage = "o {0} tem de ser compativel com o servidor inforqui (@inforqui.com), e não permite os algarismos no inicio do email")]
        public string Email { get; set; }

        //O password do utilizador
        [Required(ErrorMessage = "O campo do {0} é obrigatoria")]
        [StringLength(100, ErrorMessage = "O campo do {0} tem de ser com um caracter espe.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        //O confirmar password do utilizador
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        //A Morada do utilizador
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Morada do utilizador")]
        [RegularExpression("[A-Z][A-ZÁÉÍÓÚÀÈÌÒÙÇaa-záéíóúàèìòùç]+( [A-ZÁÉÍÓÚÀÈÌÒÙÇa-záéíóúàèìòùç0-9])+")]
        public string Morada { get; set; }

        // O código postal do utilizador
        [Required(ErrorMessage = "O {0} é preenchimento obrigatoria")]
        [Display(Name = "Código Postal de utilizador")]
        [RegularExpression("[0-9]+[-][0-9]{3}", ErrorMessage = "O campo {0} vai aceitar 7 algarismos e um (-)")]
        public string CodPostal { get; set; }

        //O NIF do utilizador
        [Required(ErrorMessage = "O {0} é preenchimento obrigatoria")]
        [Display(Name = "O NIF do utilizador")]
        [RegularExpression("[0-9]{9}", ErrorMessage = "O campo {0} só vai aceitar 9 algarismos")]
        public int NIF { get; set; }

        //O Contacto do utilizador
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Contacto do utilizador")]
        [RegularExpression("[9](1|2|3|6){1}([0-9]+){7}", ErrorMessage = "O {0} só aceita nove algarismos")]
        public string Contacto { get; set; }

        //O Imgem do utilizador
        //[Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Imagem de Utilizador")]
        public string Imagem { get; set; }
       
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}