using Lazy.Abp.MediaKit.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Lazy.Abp.MediaKit.Permissions
{
    public class MediaKitPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MediaKitPermissions.GroupName, L("Permission:MediaKit"));

            var mediaGroup = myGroup.AddPermission(MediaKitPermissions.Media.Default, L("Permission:Media"));
            mediaGroup.AddChild(MediaKitPermissions.Media.Create, L("Permission:Create"));
            mediaGroup.AddChild(MediaKitPermissions.Media.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MediaKitResource>(name);
        }
    }
}