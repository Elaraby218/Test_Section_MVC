using Microsoft.EntityFrameworkCore;


namespace Test_Section.Models
{
    public class AppDbContext : DbContext 
    {
        public DbSet<Students>Student { get; set; }

        public AppDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  string constring = _configuration.GetConnectionString("DefaultConnection"); 

            optionsBuilder.UseSqlite("Data Source = AppDB.db;");

           // optionsBuilder.UseSqlServer("Data Source=DESKTOP-1ULGF16\\SQLEXPRESS;Initial Catalog = TestSection ;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

       
    }
}
