using System;
using Lazy.Abp.MediaKit.Medias;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Lazy.Abp.MediaKit.EntityFrameworkCore
{
    public static class MediaKitDbContextModelCreatingExtensions
    {
        public static void ConfigureMediaKit(
            this ModelBuilder builder,
            Action<MediaKitModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new MediaKitModelBuilderConfigurationOptions(
                MediaKitDbProperties.DbTablePrefix,
                MediaKitDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            builder.Entity<Media>(b =>
            {
                b.ToTable(options.TablePrefix + "Medias", options.Schema);

                b.Property(p => p.Md5).HasMaxLength(MediaConsts.MaxMd5Length).IsRequired();

                b.ConfigureByConvention();

                b.HasIndex(p => new { p.TenantId, p.Md5 })
                .HasDatabaseName("IX_Media_Tenant_Md5")
                .IsUnique();
            });
        }
    }
}