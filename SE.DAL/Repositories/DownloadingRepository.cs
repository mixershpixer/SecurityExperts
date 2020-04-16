using SE.DAL.Entities;
using SE.DAL.Interfaces;

namespace SE.DAL.Repositories
{
    public class DownloadingRepository : BaseRepository<Downloading>, IDownloadingRepository
    {
        public DownloadingRepository(SEContext context) : base(context)
        {
        }
    }
}
