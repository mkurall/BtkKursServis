using Microsoft.EntityFrameworkCore;

namespace BtkKursServis.Model
{
    public class KursDbContext : DbContext
    {
        public KursDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=btk_kurs_db;Trusted_Connection=True;Encrypt=False");
        }

        public DbSet<Kurs> Kurslar { get; set; }    
    }
}
