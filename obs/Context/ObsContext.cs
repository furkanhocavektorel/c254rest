using Microsoft.EntityFrameworkCore;

namespace obs.Context
{
    public class ObsContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=obd;User Id=sa;Password=Asd123asd.;TrustServerCertificate=True;Trusted_Connection=False;");
            optionsBuilder.UseSqlServer("Server=LAB501-OGRETMEN;Database=obs;TrustServerCertificate=True;Trusted_Connection=True;");
        }

    }
}
