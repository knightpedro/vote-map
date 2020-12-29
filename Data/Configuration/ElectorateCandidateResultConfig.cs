using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoteMap.Data.Models;

namespace VoteMap.Data.Configuration
{
    public class ElectorateCandidateResultConfig : IEntityTypeConfiguration<ElectorateCandidateResult>
    {
        public void Configure(EntityTypeBuilder<ElectorateCandidateResult> builder)
        {
            builder.HasOne(e => e.CandidateCampaign)
                .WithOne(c => c.Result)
                .IsRequired();
        }
    }
}
