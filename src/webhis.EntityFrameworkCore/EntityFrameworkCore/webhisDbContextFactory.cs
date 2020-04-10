using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using webhis.Configuration;
using webhis.Web;

namespace webhis.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class webhisDbContextFactory : IDesignTimeDbContextFactory<webhisDbContext>
    {
        public webhisDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<webhisDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            webhisDbContextConfigurer.Configure(builder, configuration.GetConnectionString(webhisConsts.ConnectionStringName));

            return new webhisDbContext(builder.Options);
        }
    }
}
