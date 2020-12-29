using Microsoft.EntityFrameworkCore;
using VoteMap.Data.Models;

namespace VoteMap.Data
{
    public class VoteMapDbContext : DbContext
    {
        public DbSet<Booth> Booths { get; set; }
        public DbSet<BoothCandidateResult> BoothCandidateResults { get; set; }
        public DbSet<BoothPartyResult> BoothPartyResults { get; set; }
        public DbSet<BoothVote> BoothVotes { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<CandidateCampaign> CandidateCampaigns { get; set; }
        public DbSet<Election> Elections { get; set; }
        public DbSet<Electorate> Electorates { get; set; }
        public DbSet<ElectorateCandidateResult> ElectorateCandidateResults { get; set; }
        public DbSet<ElectoratePartyResult> ElectoratePartyResults { get; set; }
        public DbSet<ElectorateVote> ElectorateVotes { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<PartyCampaign> PartyCampaigns { get; set; }

        public VoteMapDbContext(DbContextOptions<VoteMapDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(VoteMapDbContext).Assembly);
        }
    }
}
