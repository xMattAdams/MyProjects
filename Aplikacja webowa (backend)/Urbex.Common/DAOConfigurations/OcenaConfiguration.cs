using Urbex.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Urbex.Data.Sql.DAOConfigurations
{
    public class OcenaConfiguration : IEntityTypeConfiguration<Ocena>
    {
        public void Configure(EntityTypeBuilder<Ocena> builder)
        {
            builder.Property(c => c.OcenaId).IsRequired(); //not null
            builder.Property(c => c.WygladOcena).IsRequired(); //not null
            builder.Property(c => c.HistoriaOcena).IsRequired(); //not null
            builder.Property(c => c.ParanormalnoscOcena).IsRequired(); //not null

           

            builder.ToTable("Ocena");
        }
    }

}