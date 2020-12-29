using Microsoft.EntityFrameworkCore;
using VoteMap.Data.Models;

namespace VoteMap.Data.Test.Common
{
    public class TestDbContext : VoteMapDbContext
    {
        public TestDbContext(DbContextOptions<VoteMapDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ignore geometry type, not supported by Sqlite
            modelBuilder.Entity<Booth>().Ignore(b => b.Location);
        }
    }
}
