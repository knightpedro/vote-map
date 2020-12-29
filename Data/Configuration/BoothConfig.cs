using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoteMap.Data.Models;

namespace VoteMap.Data.Configuration
{
    public class BoothConfig : IEntityTypeConfiguration<Booth>
    {
        public void Configure(EntityTypeBuilder<Booth> builder)
        {
            builder.Property(b => b.Name).IsRequired();
        }
    }
}
