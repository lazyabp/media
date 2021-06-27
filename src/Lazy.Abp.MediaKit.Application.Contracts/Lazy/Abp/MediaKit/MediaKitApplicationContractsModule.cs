using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Lazy.Abp.MediaKit
{
    [DependsOn(
        typeof(MediaKitDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class MediaKitApplicationContractsModule : AbpModule
    {

    }
}
