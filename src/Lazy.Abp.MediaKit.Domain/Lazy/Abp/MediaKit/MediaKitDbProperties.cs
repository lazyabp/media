namespace Lazy.Abp.MediaKit
{
    public static class MediaKitDbProperties
    {
        public static string DbTablePrefix { get; set; } = "MediaKit";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "MediaKit";
    }
}
