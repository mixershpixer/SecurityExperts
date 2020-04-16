using SE.DAL.Interfaces;
using System;
using System.Threading.Tasks;

namespace SE.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private SEContext _context;

        public UnitOfWork(SEContext context)
        {
            _context = context;
        }

        private ICommentRepository commentRepository;
        private IDownloadingRepository downloadingRepository;
        private IMaterialRepository materialRepository;
        private IRatingRepository ratingRepository;
        private IUserRepository userRepository;

        public ICommentRepository Comments
        {
            get
            {
                if (commentRepository == null)
                {
                    commentRepository = new CommentRepository(_context);
                }
                return commentRepository;
            }
        }

        public IDownloadingRepository Downloadings
        {
            get
            {
                if (downloadingRepository == null)
                {
                    downloadingRepository = new DownloadingRepository(_context);
                }
                return downloadingRepository;
            }
        }

        public IMaterialRepository Materials
        {
            get
            {
                if (materialRepository == null)
                {
                    materialRepository = new MaterialRepository(_context);
                }
                return materialRepository;
            }
        }

        public IRatingRepository Ratings
        {
            get
            {
                if (ratingRepository == null)
                {
                    ratingRepository = new RatingRepository(_context);
                }
                return ratingRepository;
            }
        }

        public IUserRepository Users
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(_context);
                }
                return userRepository;
            }
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
