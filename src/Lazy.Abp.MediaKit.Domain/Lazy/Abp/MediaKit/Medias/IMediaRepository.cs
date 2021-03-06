using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Lazy.Abp.MediaKit.Medias
{
    public interface IMediaRepository : IRepository<Media, Guid>
    {
        Task<Media> GetByMd5Async(string md5, CancellationToken cancellationToken = default);
        Task<List<Media>> GetByMd5sAsync(IEnumerable<string> md5s, CancellationToken cancellationToken = default);

        Task<List<Media>> FindMd5sAsync(IEnumerable<string> md5s, CancellationToken cancellationToken = default);

        Task<List<Media>> FindByIdsAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken = default);

        Task<long> GetCountAsync(
            int? minSize = null,
            int? maxSize = null,
            DateTime? creationAfter = null,
            DateTime? creationBefore = null,
            string filter = null,
            CancellationToken cancellationToken = default
        );

        Task<List<Media>> GetListAsync(
            int? minSize = null,
            int? maxSize = null,
            DateTime? creationAfter = null,
            DateTime? creationBefore = null,
            string filter = null,
            int maxResultCount = 10,
            int skipCount = 0,
            string sorting = null,
            CancellationToken cancellationToken = default
        );
    }
}
