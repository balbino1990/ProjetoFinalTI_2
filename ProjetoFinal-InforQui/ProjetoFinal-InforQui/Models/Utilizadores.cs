using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Key]
        [Display(Name = "Identificador de utilizador")]
        public int UtilizadorID { get; set; }
        //O Nome do utilizador
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Nome do utilizador")]
        public string Nome { get; set; }
        //O Apelido do utilizador
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Apelido de utilizador")]
        public string Apelido { get; set; }
        //O Email do utilizador
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Email de utilizador")]
        public string Email { get; set; }
        //A Morada do utilizador
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Morada do utilizador")]
        public string Morada { get; set; }
        //O Contacto do utilizador
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Contacto do utilizador")]
        public string Contacto { get; set; }
        //O Imgem do utilizador
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Imagem de Utilizador")]
        public  string Imagem { get; set; }

        //##################################################################
        //################Relacionamento e chaves estrangeiras##############
        //##################################################################
        //1 Utilizador relaciona com muitas Compras
        public virtual ICollection<Compras> ListaDeCompras { get; set; }
    }
}