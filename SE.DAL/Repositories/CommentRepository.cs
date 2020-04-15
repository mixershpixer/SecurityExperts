using SE.DAL.Entities;
using SE.DAL.Interfaces;

namespace SE.DAL.Repositories
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(SEContext context) : base(context)
        {
        }
    }
}
