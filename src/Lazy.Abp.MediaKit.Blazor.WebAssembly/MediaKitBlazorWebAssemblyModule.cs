using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Lazy.Abp.MediaKit.Blazor.WebAssembly
{
    [DependsOn(
        typeof(MediaKitBlazorModule),
        typeof(MediaKitHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class MediaKitBlazorWebAssemblyModule : AbpModule
    {
        
    }
}