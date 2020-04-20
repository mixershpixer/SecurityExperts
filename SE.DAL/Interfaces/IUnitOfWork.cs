using System;
using System.Threading.Tasks;

namespace SE.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICommentRepository CommentRepository { get; }
        IDownloadingRepository DownloadingRepository { get; }
        IMaterialRepository MaterialRepository { get; }
        IRatingRepository RatingRepository { get; }
        IUserRepository UserRepository { get; }
        Task<int> SaveAsync();
        void Dispose(bool disposing);
    }
}
