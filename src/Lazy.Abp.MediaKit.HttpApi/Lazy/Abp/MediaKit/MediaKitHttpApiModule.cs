using Localization.Resources.AbpUi;
using Lazy.Abp.MediaKit.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;
using Lazy.Abp.Core;
using Lazy.Abp.MediaKit.Medias;

namespace Lazy.Abp.MediaKit
{
    [DependsOn(
        typeof(MediaKitApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule),
        typeof(LazyAbpCoreModule)
    )]
    public class MediaKitHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(MediaKitHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<MediaKitResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });

            var configuration = context.Services.GetConfiguration();

            Configure<UploadTokenVerifyOption>(configuration.GetSection("FastDFSProxy:Default"));
        }
    }
}
