using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Lazy.Abp.MediaKit.EntityFrameworkCore
{
    public class MediaKitHttpApiHostMigrationsDbContext : AbpDbContext<MediaKitHttpApiHostMigrationsDbContext>
    {
        public MediaKitHttpApiHostMigrationsDbContext(DbContextOptions<MediaKitHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureMediaKit();
        }
    }
}
