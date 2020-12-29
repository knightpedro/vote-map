using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoteMap.Data.Models;

namespace VoteMap.Data.Configuration
{
    public class PartyConfig : IEntityTypeConfiguration<Party>
    {
        public void Configure(EntityTypeBuilder<Party> builder)
        {
            builder.Property(p => p.Name).IsRequired();
        }
    }
}
