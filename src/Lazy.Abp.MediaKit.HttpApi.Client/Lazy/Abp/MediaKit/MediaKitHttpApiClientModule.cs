using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Lazy.Abp.MediaKit
{
    [DependsOn(
        typeof(MediaKitApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class MediaKitHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "MediaKit";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(MediaKitApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
