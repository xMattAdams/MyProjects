using Urbex.Data.Sql.DAOConfigurations;
using Urbex.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;

namespace Urbex.Data.Sql
{
    public class UrbexDbContext : DbContext
    {
        public UrbexDbContext(DbContextOptions<UrbexDbContext> options) : base(options) { }

        public virtual DbSet<Eksploratorzy> Eksploratorzy { get; set; }
        public virtual DbSet<Obiekt> Obiekt { get; set; }
        public virtual DbSet<Ocena> Ocena { get; set; }
        public virtual DbSet<Przedmioty> Przedmioty { get; set; }
        public virtual DbSet<Zdarzenia> Zdarzenia { get; set; }
        public virtual DbSet<EksploratorzyObiekt> EksploratorzyObiekt { get; set; }
        public virtual DbSet<EksploratorzyPrzedmioty> EksploratorzyPrzedmioty { get; set; }
        public virtual DbSet<EksploratorzyZdarzenia> EksploratorzyZdarzenia { get; set; }
        


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EksploratorzyConfiguration());
            builder.ApplyConfiguration(new ObiektConfiguration());
            builder.ApplyConfiguration(new OcenaConfiguration());
            builder.ApplyConfiguration(new PrzedmiotyConfiguration());
            builder.ApplyConfiguration(new ZdarzeniaConfiguration());
            


            


        }
    }
}