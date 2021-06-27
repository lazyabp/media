using Lazy.Abp.MediaKit.Medias;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Lazy.Abp.MediaKit.EntityFrameworkCore
{
    [ConnectionStringName(MediaKitDbProperties.ConnectionStringName)]
    public interface IMediaKitDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        DbSet<Media> Medias { get; }
    }
}