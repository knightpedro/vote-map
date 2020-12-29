using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoteMap.Data.Models;

namespace VoteMap.Data.Configuration
{
    public class ElectorateConfig : IEntityTypeConfiguration<Electorate>
    {
        public void Configure(EntityTypeBuilder<Electorate> builder)
        {
            builder.Property(e => e.Name).IsRequired();

            builder.Property(e => e.Type)
                .IsRequired()
                .HasConversion<string>();
        }
    }
}
