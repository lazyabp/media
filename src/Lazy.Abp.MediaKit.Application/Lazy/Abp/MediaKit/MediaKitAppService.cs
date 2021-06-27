using Lazy.Abp.MediaKit.Localization;
using Volo.Abp.Application.Services;

namespace Lazy.Abp.MediaKit
{
    public abstract class MediaKitAppService : ApplicationService
    {
        protected MediaKitAppService()
        {
            LocalizationResource = typeof(MediaKitResource);
            ObjectMapperContext = typeof(MediaKitApplicationModule);
        }
    }
}
