using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoteMap.Data.Models;

namespace VoteMap.Data.Configuration
{
    public class BoothPartyResultConfig : IEntityTypeConfiguration<BoothPartyResult>
    {
        public void Configure(EntityTypeBuilder<BoothPartyResult> builder)
        {
            builder.HasOne(b => b.Booth)
                .WithMany(b => b.PartyResults)
                .IsRequired();

            builder.HasOne(b => b.PartyCampaign)
                .WithMany(p => p.BoothResults)
                .IsRequired();
        }
    }
}
