using Urbex.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Urbex.Data.Sql.DAOConfigurations
{
    public class ZdarzeniaConfiguration : IEntityTypeConfiguration<Zdarzenia>
    {
        public void Configure(EntityTypeBuilder<Zdarzenia> builder)
        {
            builder.Property(c => c.ZdarzenieId).IsRequired(); //not null
            builder.Property(c => c.Data).IsRequired(); //not null
            builder.Property(c => c.OpisZdarzenia).IsRequired(); //not null


            builder.HasMany(x => x.EksploratorzyZdarzenia)
                .WithOne(x => x.Zdarzenia)
                .HasForeignKey(x => x.ZdarzenieId)//relacja - eksplorator moze wystawic wiele ocen
                .OnDelete(DeleteBehavior.Restrict); //blokada usuwania



            builder.ToTable("Zdarzenie");
        }
    }

}