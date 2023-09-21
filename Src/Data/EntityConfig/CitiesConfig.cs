using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntityConfig
{
    public class CitiesConfig : IEntityTypeConfiguration<Cities>
    {
        public void Configure(EntityTypeBuilder<Cities> builder)
        {
            builder.HasKey(x => x.CityID);

            builder.Property(x => x.ZipCode)
                .HasMaxLength(8)
                .HasColumnType("char");

            builder.HasOne(x => x.States)
                .WithMany()
                .HasForeignKey(x => x.StateID);

            builder.Property(x => x.City)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
