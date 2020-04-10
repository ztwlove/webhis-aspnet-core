using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using webhis.Authorization.Roles;
using webhis.Authorization.Users;
using webhis.MultiTenancy;

namespace webhis.EntityFrameworkCore
{
    public class webhisDbContext : AbpZeroDbContext<Tenant, Role, User, webhisDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public webhisDbContext(DbContextOptions<webhisDbContext> options)
            : base(options)
        {
        }
    }
}
