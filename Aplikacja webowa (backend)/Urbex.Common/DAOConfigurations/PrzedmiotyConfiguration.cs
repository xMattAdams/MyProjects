using Urbex.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Urbex.Data.Sql.DAOConfigurations
{
    public class PrzedmiotyConfiguration : IEntityTypeConfiguration<Przedmioty>
    {
        public void Configure(EntityTypeBuilder<Przedmioty> builder)
        {
            builder.Property(c => c.PrzedmiotId).IsRequired(); //not null
            builder.Property(c => c.PrzedmiotNazwa).IsRequired(); //not null 
            builder.Property(c => c.PrzedmiotOpis); //can be null
            




            builder.ToTable("Przedmiot");
        }
    }

}