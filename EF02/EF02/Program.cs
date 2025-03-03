using Microsoft.EntityFrameworkCore;

namespace EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ITIDbContext>();
            optionsBuilder.UseSqlServer("Server = .; Database = ITIDb; Trusted_Connection = true; TrustServerCertificate = True;");
            using ITIDbContext dbContext = new ITIDbContext(optionsBuilder.Options);
        }
    }
}