using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace VoteMap.Data.Test.Common
{
    public static class ContextOptionsFactory
    {
        public static DbContextOptions<T> CreateSqliteOptions<T>() where T : DbContext
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder() { DataSource = ":memory:" };
            var connection = new SqliteConnection(connectionStringBuilder.ToString());
            var options = new DbContextOptionsBuilder<T>()
                .UseSqlite(connection)
                .Options;
            return options;
        }
    }
}
