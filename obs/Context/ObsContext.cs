using Microsoft.EntityFrameworkCore;
using obs.entity;

namespace obs.Context
{
    public class ObsContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=obd;User Id=sa;Password=Asd123asd.;TrustServerCertificate=True;Trusted_Connection=False;");
            optionsBuilder.UseSqlServer("Server=LAB501-OGRETMEN;Database=obs;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        public DbSet<Auth> Auths { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
