using System;
using System.Threading.Tasks;

namespace SE.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICommentRepository Comments { get; }
        IDownloadingRepository Downloadings { get; }
        IMaterialRepository Materials { get; }
        IRatingRepository Ratings { get; }
        IUserRepository Users { get; }
        Task<int> SaveAsync();
        void Dispose(bool disposing);
    }
}
