using Microsoft.EntityFrameworkCore;

namespace TestEFCore
{
    public class Contexto: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProjetoRussia1;Trusted_Connection=True;ConnectRetryCount=0");
        }

        public DbSet<Pessoa> Pessoas { get; set; }

    }
}
