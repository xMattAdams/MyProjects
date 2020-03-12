using Urbex.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Urbex.Data.Sql.DAOConfigurations
{
    public class EksploratorzyConfiguration : IEntityTypeConfiguration<Eksploratorzy>
    {
        public void Configure(EntityTypeBuilder<Eksploratorzy> builder)
        {
            builder.Property(c => c.OsobaId).IsRequired(); //not null
            builder.Property(c => c.OsobaTelefon).IsRequired(); //not null
            builder.Property(c => c.OsobaImie).IsRequired(); //not null
            builder.Property(c => c.OsobaNazwisko).IsRequired(); //not null
          
            builder.HasMany(x => x.Ocena)
                .WithOne(x => x.Eksploratorzy)
                .HasForeignKey(x=>x.OcenaId)//relacja - eksplorator moze wystawic wiele ocen
                .OnDelete(DeleteBehavior.Restrict); //blokada usuwania

            builder.HasMany(x => x.EksploratorzyZdarzenia)
                .WithOne(x => x.Eksploratorzy)
                .HasForeignKey(x => x.OsobaId)//relacja - eksplorator moze wystawic wiele ocen
                .OnDelete(DeleteBehavior.Restrict); //blokada usuwania


            builder.ToTable("Eksplorator");
        }
    }
        
}