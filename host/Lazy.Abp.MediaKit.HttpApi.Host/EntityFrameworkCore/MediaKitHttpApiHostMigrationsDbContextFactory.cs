using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Lazy.Abp.MediaKit.EntityFrameworkCore
{
    public class MediaKitHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<MediaKitHttpApiHostMigrationsDbContext>
    {
        public MediaKitHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<MediaKitHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("MediaKit"));

            return new MediaKitHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
