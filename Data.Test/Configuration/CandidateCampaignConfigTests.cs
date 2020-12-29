using Microsoft.EntityFrameworkCore;
using VoteMap.Data.Models;
using VoteMap.Data.Test.Common;
using Xunit;

namespace VoteMap.Data.Test.Configuration
{
    public class CandidateCampaignConfigTests : ContextTestBase
    {
        [Fact]
        public void Save_Party_NotRequired()
        {
            var election = new Election();
            var candidate = new Candidate { Name = "Test Candidate" };
            var campaign = new CandidateCampaign
            {
                Candidate = candidate,
                Election = election,
            };
            context.CandidateCampaigns.Add(campaign);
            context.SaveChanges();
        }

        [Fact]
        public void Save_Candidate_Required()
        {
            var election = new Election();
            var campaign = new CandidateCampaign
            {
                Election = election,
            };
            context.CandidateCampaigns.Add(campaign);
            Assert.Throws<DbUpdateException>(() => context.SaveChanges());
        }

        [Fact]
        public void Save_Election_Required()
        {
            var candidate = new Candidate { Name = "Test Candidate" };
            var campaign = new CandidateCampaign
            {
                Candidate = candidate
            };
            context.CandidateCampaigns.Add(campaign);
            Assert.Throws<DbUpdateException>(() => context.SaveChanges());
        }
    }
}
