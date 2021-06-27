using Volo.Abp.Reflection;

namespace Lazy.Abp.MediaKit.Permissions
{
    public class MediaKitPermissions
    {
        public const string GroupName = "MediaKit";

        public class Media
        {
            public const string Default = GroupName + ".Media";

            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(MediaKitPermissions));
        }
    }
}