using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoteMap.Data.Models;

namespace VoteMap.Data.Configuration
{
    public class PartyCampaignConfig : IEntityTypeConfiguration<PartyCampaign>
    {
        public void Configure(EntityTypeBuilder<PartyCampaign> builder)
        {
            builder.HasOne(p => p.Election)
                .WithMany(e => e.PartyCampaigns)
                .IsRequired();

            builder.HasOne(p => p.Party)
                .WithMany(p => p.PartyCampaigns)
                .IsRequired();
        }
    }
}
