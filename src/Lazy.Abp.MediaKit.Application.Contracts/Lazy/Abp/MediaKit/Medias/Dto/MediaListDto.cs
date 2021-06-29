using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.MediaKit.Medias.Dto
{
    public class MediaListDto : EntityDto<Guid>
    {
        public string Url { get; set; }

        public string Md5 { get; set; }

        public string MimeType { get; set; }

        public int Size { get; set; }
    }
}
