using api_csharp.Model;
using Microsoft.EntityFrameworkCore;

namespace api_csharp.Data
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<ProdutoClass> Produto { get; set; }
    }
}
