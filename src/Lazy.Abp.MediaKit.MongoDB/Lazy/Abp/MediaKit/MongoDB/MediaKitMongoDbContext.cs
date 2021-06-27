using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.MediaKit.MongoDB
{
    [ConnectionStringName(MediaKitDbProperties.ConnectionStringName)]
    public class MediaKitMongoDbContext : AbpMongoDbContext, IMediaKitMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureMediaKit();
        }
    }
}