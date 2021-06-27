using Lazy.Abp.MediaKit.Medias.Dto;
using Lazy.Abp.MediaKit.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.MediaKit.Medias
{
    [Authorize]
    public class MediaAppService : MediaKitAppService, IMediaAppService
    {
        private readonly IMediaRepository _repository;

        public MediaAppService(IMediaRepository repository)
        {
            _repository = repository;
        }

        public async Task<MediaDto> GetAsync(Guid id)
        {
            var media = await _repository.GetAsync(id);

            return ObjectMapper.Map<Media, MediaDto>(media);
        }

        public async Task<MediaDto> GetByMd5Async(string md5)
        {
            var media = await _repository.GetByMd5Async(md5);

            return ObjectMapper.Map<Media, MediaDto>(media);
        }

        public async Task<PagedResultDto<MediaDto>> GetListAsync(MediaListRequestDto input)
        {
            var count = await _repository.GetCountAsync(input.MinSize, input.MaxSize, input.CreationStart, input.CreationEnd, input.Filter);

            var list = await _repository.GetListAsync(input.MinSize, input.MaxSize, input.CreationStart,
                input.CreationEnd, input.Filter, input.MaxResultCount, input.SkipCount, input.Sorting);

            return new PagedResultDto<MediaDto>(
                count,
                ObjectMapper.Map<List<Media>, List<MediaDto>>(list)
            );
        }

        [Authorize(MediaKitPermissions.Media.Create)]
        public async Task<MediaDto> CreateAsync(MediaCreateDto input)
        {
            var media = await _repository.GetByMd5Async(input.Md5);
            if (null == media)
            {
                media = new Media(GuidGenerator.Create(), CurrentTenant.Id, input.Url, input.Md5,
                   input.MimeType, input.Path, input.Domain, input.Scene, input.Size, input.Mtime, input.Scenes, input.Src);

                await _repository.InsertAsync(media);
            }

            return ObjectMapper.Map<Media, MediaDto>(media);
        }

        [Authorize(MediaKitPermissions.Media.Delete)]
        public async Task DeleteAsync(Guid id)
        {
            var media = await _repository.GetAsync(id);

            if (null != media)
                await _repository.DeleteAsync(media);
        }
    }
}
