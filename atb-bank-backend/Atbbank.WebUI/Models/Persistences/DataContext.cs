using Atbbank.WebUI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Atbbank.WebUI.Models.Persistences
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<UsefulCard> UsefulCards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }

    }

   
}
