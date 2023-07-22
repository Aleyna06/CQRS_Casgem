using Microsoft.EntityFrameworkCore;

namespace CQRS_Casgem.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4FNRCPJ\\SQLEXPRESS;initial catalog=CasgemCQRSDb;integrated Security=true");
            
        }
        public DbSet<Product> Products { get; set; }

    }
}
