using SE.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SE.BLL.Interfaces
{
    public interface ICommentService
    {
        Task<CommentViewModel> AddComment(Guid userId, Guid materialId, string commentText);
        Task<bool> DeleteComment(Guid commentId);
    }
}
