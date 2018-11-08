using Microsoft.EntityFrameworkCore;

namespace TestEFCore
{
    public class ContextoMemory : DbContext
    {
       
        public ContextoMemory(DbContextOptions<ContextoMemory> options)
            : base(options)
        { }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
