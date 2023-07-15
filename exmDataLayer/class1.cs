using examDomin;
using Microsoft.EntityFrameworkCore;

namespace exmDataLayer
{
    public class examDBContext : DbContext 
    {
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Custmor> Custmor { get; set; }
        public DbSet<Parts> Parts { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = examDB");
        }



    }
}