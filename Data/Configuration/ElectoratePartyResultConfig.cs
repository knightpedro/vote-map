using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoteMap.Data.Models;

namespace VoteMap.Data.Configuration
{
    public class ElectoratePartyResultConfig : IEntityTypeConfiguration<ElectoratePartyResult>
    {
        public void Configure(EntityTypeBuilder<ElectoratePartyResult> builder)
        {
            builder.HasOne(e => e.Electorate)
                .WithMany(e => e.PartyResults)
                .IsRequired();

            builder.HasOne(e => e.PartyCampaign)
                .WithMany(p => p.ElectorateResults)
                .IsRequired();
        }
    }
}
