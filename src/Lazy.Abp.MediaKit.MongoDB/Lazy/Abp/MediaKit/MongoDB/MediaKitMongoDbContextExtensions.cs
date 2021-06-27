using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.MediaKit.MongoDB
{
    public static class MediaKitMongoDbContextExtensions
    {
        public static void ConfigureMediaKit(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new MediaKitMongoModelBuilderConfigurationOptions(
                MediaKitDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}