using Microsoft.EntityFrameworkCore;

namespace NewsProject.Models
{
    public class newsdbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=newsdb;Trusted_Connection=True;");
        }
        public DbSet<News> News { get; set; }
    }
}
