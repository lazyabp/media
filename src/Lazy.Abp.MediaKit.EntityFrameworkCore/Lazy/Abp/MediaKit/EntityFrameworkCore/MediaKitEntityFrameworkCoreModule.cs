using Lazy.Abp.MediaKit.Medias;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Lazy.Abp.MediaKit.EntityFrameworkCore
{
    [DependsOn(
        typeof(MediaKitDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class MediaKitEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MediaKitDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
                options.AddRepository<Media, EfCoreMediaRepository>();
            });
        }
    }
}