using SE.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SE.DAL.Interfaces
{
    public interface ICommentRepository : IBaseRepository<Comment>
    {
        Task<IEnumerable<Comment>> GetMaterialComments(Guid materialId);
        Task<Comment> AddComment(Guid userId, Guid materialId, string commentText, DateTime date);
        Task<bool> DeleteComment(Guid commentId);
    }
}
