using MvcEntityCompleto6.Models;
using Microsoft.EntityFrameworkCore;



namespace MvcEntityCompleto6.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Transporte> Transporte { get; set; }

    }
}
