using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Tolo.MyAbp.Authorization.Roles;
using Tolo.MyAbp.Authorization.Users;
using Tolo.MyAbp.MultiTenancy;
using Abp.IdentityServer4;

namespace Tolo.MyAbp.EntityFrameworkCore
{
    public class MyAbpDbContext : AbpZeroDbContext<Tenant, Role, User, MyAbpDbContext>, IAbpPersistedGrantDbContext
    {
        /* Define a DbSet for each entity of the application */

        public MyAbpDbContext(DbContextOptions<MyAbpDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PersistedGrantEntity> PersistedGrants { get; set; }
    }
}
