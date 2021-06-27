using Lazy.Abp.MediaKit.Medias;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Lazy.Abp.MediaKit.EntityFrameworkCore
{
    [ConnectionStringName(MediaKitDbProperties.ConnectionStringName)]
    public class MediaKitDbContext : AbpDbContext<MediaKitDbContext>, IMediaKitDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Media> Medias { get; set; }

        public MediaKitDbContext(DbContextOptions<MediaKitDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureMediaKit();
        }
    }
}