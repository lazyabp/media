using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Lazy.Abp.MediaKit
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(MediaKitDomainSharedModule)
    )]
    public class MediaKitDomainModule : AbpModule
    {

    }
}
