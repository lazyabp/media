using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.MediaKit.MongoDB
{
    [ConnectionStringName(MediaKitDbProperties.ConnectionStringName)]
    public interface IMediaKitMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
