using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntityConfig
{
    public class AdressesConfig : IEntityTypeConfiguration<Adresses>
    {
        public void Configure(EntityTypeBuilder<Adresses> builder)
        {
            builder.HasKey(x => x.AddressID);

            builder.HasOne(x => x.Neighborhoods)
                .WithMany()
                .HasForeignKey(x => x.NeighborhoodID);

            builder.HasOne(x => x.Cities)
                .WithMany()
                .HasForeignKey(x => x.CityID);

            builder.HasOne(x => x.States)
                .WithMany()
                .HasForeignKey(x => x.StateID);

            builder.Property(x => x.ZipCode)
                .HasMaxLength(8)
                .HasColumnType("char")
                .IsRequired();

            builder.Property(x => x.Address)
                .HasMaxLength(150)
                .HasColumnType("nvarchar")
                .IsRequired();
        }
    }
}
