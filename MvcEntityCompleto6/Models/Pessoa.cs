using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcEntityCompleto6.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Column("Id")]
        [Display(Name = "Codigo")]

        public int Id { get; set; }





        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }



        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }



        [Column("Salario")]
        [Display(Name = "Salario")]
        public double Salario { get; set; }


        [Column("Apelido")]
        [Display(Name = "Apelido")]
        public string Apelido { get; set; }
    }
}

