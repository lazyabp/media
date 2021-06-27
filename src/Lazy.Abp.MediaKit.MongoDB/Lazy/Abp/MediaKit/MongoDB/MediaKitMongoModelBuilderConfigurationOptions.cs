using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.MediaKit.MongoDB
{
    public class MediaKitMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public MediaKitMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}