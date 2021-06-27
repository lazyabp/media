using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Lazy.Abp.MediaKit.EntityFrameworkCore
{
    public class MediaKitModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public MediaKitModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}