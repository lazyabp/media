using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Lazy.Abp.MediaKit.Blazor.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsServerThemingModule),
        typeof(MediaKitBlazorModule)
        )]
    public class MediaKitBlazorServerModule : AbpModule
    {
        
    }
}