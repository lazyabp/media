using AutoMapper;
using Lazy.Abp.MediaKit.Medias;
using Lazy.Abp.MediaKit.Medias.Dto;

namespace Lazy.Abp.MediaKit
{
    public class MediaKitApplicationAutoMapperProfile : Profile
    {
        public MediaKitApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */


            CreateMap<Media, MediaDto>()
                .MapExtraProperties();

            CreateMap<Media, MediaListDto>();
        }
    }
}