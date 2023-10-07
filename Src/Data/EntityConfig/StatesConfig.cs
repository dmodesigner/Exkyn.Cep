using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntityConfig
{
    public class StatesConfig : IEntityTypeConfiguration<States>
    {
        public void Configure(EntityTypeBuilder<States> builder)
        {
            builder.HasKey(x => x.StateID);

            builder.Property(x => x.FU)
                .HasMaxLength(2)
                .HasColumnType("char")
                .IsRequired();

            builder.Property(x => x.State)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
