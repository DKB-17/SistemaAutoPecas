using Microsoft.EntityFrameworkCore;

namespace AutoPecas.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) {}

        public DbSet<Categoria> Categorias { get; set; }

        

    }
}
