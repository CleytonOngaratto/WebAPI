using Microsoft.EntityFrameworkCore;

namespace AspNetMVC.Models
{
    public class DestinoDbContext : DbContext
    {
        public DestinoDbContext(DbContextOptions<DestinoDbContext> options) :
            base(options)
        { }

        public DbSet<Destinos> destinos {get;set;}
    }
}
