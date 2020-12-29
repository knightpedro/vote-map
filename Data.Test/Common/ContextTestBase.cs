using Microsoft.EntityFrameworkCore;
using System;

namespace VoteMap.Data.Test.Common
{
    public abstract class ContextTestBase : IDisposable
    {
        protected readonly TestDbContext context;

        public ContextTestBase()
        {
            var options = ContextOptionsFactory.CreateSqliteOptions<VoteMapDbContext>();
            context = new TestDbContext(options);
            context.Database.OpenConnection();
            context.Database.EnsureCreated();
        }

        public void Dispose()
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}
