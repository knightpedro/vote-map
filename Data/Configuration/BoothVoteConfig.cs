using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoteMap.Data.Models;

namespace VoteMap.Data.Configuration
{
    public class BoothVoteConfig : IEntityTypeConfiguration<BoothVote>
    {
        public void Configure(EntityTypeBuilder<BoothVote> builder)
        {
            builder.HasOne(b => b.Booth)
                .WithMany(b => b.BoothVotes)
                .IsRequired();

            builder.HasOne(b => b.Electorate)
                .WithMany(e => e.BoothVotes)
                .IsRequired();

            builder.HasOne(b => b.Election)
                .WithMany(e => e.BoothVotes)
                .IsRequired();
        }
    }
}
