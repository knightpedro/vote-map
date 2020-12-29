using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoteMap.Data.Models;

namespace VoteMap.Data.Configuration
{
    public class BoothCandidateResultConfig : IEntityTypeConfiguration<BoothCandidateResult>
    {
        public void Configure(EntityTypeBuilder<BoothCandidateResult> builder)
        {
            builder.HasOne(b => b.Booth)
                .WithMany(b => b.CandidateResults)
                .IsRequired();

            builder.HasOne(b => b.CandidateCampaign)
                .WithMany(c => c.BoothResults)
                .IsRequired();
        }
    }
}
