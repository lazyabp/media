using Lazy.Abp.MediaKit.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Lazy.Abp.MediaKit
{
    public abstract class MediaKitController : AbpController
    {
        protected MediaKitController()
        {
            LocalizationResource = typeof(MediaKitResource);
        }
    }
}
