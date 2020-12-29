using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoteMap.Data.Models;

namespace VoteMap.Data.Configuration
{
    public class CandidateCampaignConfig : IEntityTypeConfiguration<CandidateCampaign>
    {
        public void Configure(EntityTypeBuilder<CandidateCampaign> builder)
        {
            builder.HasOne(c => c.Candidate)
                .WithMany(c => c.Campaigns)
                .IsRequired();

            builder.HasOne(c => c.Election)
                .WithMany(e => e.CandidateCampaigns)
                .IsRequired();

            builder.HasOne(c => c.Party)
                .WithMany(p => p.CandidateCampaigns)
                .IsRequired(false);
        }
    }
}
