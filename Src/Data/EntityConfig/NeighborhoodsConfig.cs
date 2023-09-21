using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntityConfig
{
    public class NeighborhoodsConfig : IEntityTypeConfiguration<Neighborhoods>
    {
        public void Configure(EntityTypeBuilder<Neighborhoods> builder)
        {
            builder.HasKey(x => x.NeighborhoodID);

            builder.HasOne(x => x.Cities)
                .WithMany()
                .HasForeignKey(x => x.CityID);

            builder.HasOne(x => x.States)
                .WithMany()
                .HasForeignKey(x => x.StateID);

            builder.Property(x => x.Neighborhood)
                .IsRequired();
        }
    }
}
