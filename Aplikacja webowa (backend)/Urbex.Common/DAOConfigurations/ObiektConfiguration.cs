using Urbex.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Urbex.Data.Sql.DAOConfigurations
{
    public class ObiektConfiguration : IEntityTypeConfiguration<Obiekt>
    {
        public void Configure(EntityTypeBuilder<Obiekt> builder)
        {
            builder.Property(c => c.ObiektId).IsRequired(); //not null
            builder.Property(c => c.Lokalizacja).IsRequired(); //not null
            builder.Property(c => c.Opis).IsRequired(); //not null
            builder.Property(c => c.Wiek); //can be null
            builder.Property(c => c.Nazwa);
            builder.Property(c => c.Rodzaj).IsRequired();

            builder.HasMany(x => x.Przedmioty)
                .WithOne(x => x.Obiekt)
                .HasForeignKey(x=>x.PrzedmiotId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.PrzedmiotId);

            builder.HasMany(x => x.Ocena)
            .WithOne(x => x.Obiekt)
            .HasForeignKey(x => x.OcenaId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasForeignKey(x => x.OcenaId);

            builder.HasMany(x => x.Zdarzenia)
                .WithOne(x => x.Obiekt)
                .HasForeignKey(x => x.ZdarzenieId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.ZdarzenieId);
                

            builder.ToTable("Obiekt");
        }
    }

}