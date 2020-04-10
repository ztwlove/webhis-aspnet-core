using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace webhis.EntityFrameworkCore
{
    public static class webhisDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<webhisDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<webhisDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
