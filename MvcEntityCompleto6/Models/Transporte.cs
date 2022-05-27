using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MvcEntityCompleto6.Models
{
    [Table("Transporte")]
    public class Transporte
    {
        [Column("Id")]
        [Display(Name = "Codigo")]

        public int Id { get; set; }




        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }



        [Column("Responsavel")]
        [Display(Name = "Responsavel")]
        public string Responsavel { get; set; }
    }
}
