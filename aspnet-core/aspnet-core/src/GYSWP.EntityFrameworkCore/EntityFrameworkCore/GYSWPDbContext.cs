using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GYSWP.Authorization.Roles;
using GYSWP.Authorization.Users;
using GYSWP.MultiTenancy;

namespace GYSWP.EntityFrameworkCore
{
    public class GYSWPDbContext : AbpZeroDbContext<Tenant, Role, User, GYSWPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public GYSWPDbContext(DbContextOptions<GYSWPDbContext> options)
            : base(options)
        {
        }
    }
}
