using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoteMap.Data.Models;

namespace VoteMap.Data.Configuration
{
    public class ElectorateVoteConfig : IEntityTypeConfiguration<ElectorateVote>
    {
        public void Configure(EntityTypeBuilder<ElectorateVote> builder)
        {
            builder.HasOne(e => e.Election)
                .WithMany(e => e.ElectorateVotes)
                .IsRequired();

            builder.HasOne(e => e.Electorate)
                .WithMany(e => e.ElectorateVotes)
                .IsRequired();
        }
    }
}
